using System;
using System.Drawing;
using System.Windows.Forms;
using GoblinSlayer.Classes;
using GoblinSlayer.Classes.Tiles.Items;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace GoblinSlayer
{

    public partial class GameUI : Form
    {
        //Game engine class
        GameEngine game = new GameEngine();

        //This bool keep track if an enemy has been killed or not.
        public bool killedEnemy;

        //Keeps score of the players gold.
        public int playerGold;

        //Keeps track of the players score.
        public int playerScore;

        //Used to serialize an object and deserialize it, this enables saving and loading of game data.
        IFormatter formatter = new BinaryFormatter();
        Stream stream;

        bool playerMoved = false;

        public GameUI()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            //This method loads the saved file.

            //Displays the map and stats again.
            DrawMap();

            //Hides the selections.
            viewEnemies.Hide();
            viewItems.Hide();

            //resets selections.
            viewEnemies.Enabled = false;
            viewItems.Enabled = false;

            //Re-enable the controls
            this.KeyPreview = true;

            ItemMessages.Visible = false;
            interactionMsgs.Text = "";
        }

        private void DrawMap()
        {
            //The dungeon map.
            dungeonMap.Text = game.ToString();

            //player stats
            playerStats.Text = game.Map.Hero.ToString();

            //Enemy and item arrays ---> relevant combo boxes.
            viewEnemies.DataSource = game.Map.enemiesArr;
            viewItems.DataSource = game.Map.arrOfItems;

            playerGold = game.Map.Hero.Wallet;


            //Shop
            Shop_Item_1.Text = game.Map.shop.DisplayWeapon(game.Map.shop.WeaponsArray[0].Cost);

            VerifyCost();
            GDiffCheck();
            LoseMethod();
            WinMethod();
        }

        //This method will change the colours to indicate if the player can buy or not.
        private void VerifyCost()
        {
            if (game.Map.shop.WeaponsArray[0].Cost <= game.Map.Hero.Wallet)
            {
                Shop_Item_1.ForeColor = Color.Green;
            }
            else
            {
                Shop_Item_1.ForeColor = Color.Black;
            }
            if (game.Map.shop.WeaponsArray[1].Cost <= game.Map.Hero.Wallet)
            {
                Shop_Item_1.ForeColor = Color.Green;
            }
            else
            {
                Shop_Item_1.ForeColor = Color.Black;
            }
            if (game.Map.shop.WeaponsArray[2].Cost <= game.Map.Hero.Wallet)
            {
                Shop_Item_1.ForeColor = Color.Green;
            }
            else
            {
                Shop_Item_1.ForeColor = Color.Black;
            }

        }

        private void LoseMethod()
        {
            if (game.Map.Hero.IsDead())
            {
                this.Hide();
                //This will contain the lose screen.
                this.KeyPreview = false;
                DeathScreen death = new DeathScreen();
                death.Show();
            }
        }

        private void WinMethod()
        {
            if (game.Map.enemiesArr.Length == 0)
            {
                this.Hide();
                //This will contain the win screen.
                this.KeyPreview = false;
                WinScreen win = new WinScreen();
                win.Show();

            }
        }

            //Movement
        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            char controls = e.KeyChar;


            switch (controls)
            {
                //Forward
                case 'w':
                case 'W':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.UP));
                    playerMoved = true;
                    game.Map.MoveEnemies();

                    break;

                //left
                case 'a':
                case 'A':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.LEFT));
                    game.Map.MoveEnemies();
                    playerMoved = true;

                    break;

                //right
                case 'd':
                case 'D':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.RIGHT));
                    game.Map.MoveEnemies();
                    playerMoved = true;

                    break;

                //Backwards
                case 's':
                case 'S':

                    game.Map.Hero.Move(game.Map.Hero.ReturnMove(Character.MovementEnum.DOWN));
                    game.Map.MoveEnemies();
                    playerMoved = true;

                    break;

                //Enemy drop down
                case 'm':
                case 'M':

                    if (!viewEnemies.Visible)
                    {
                        this.KeyPreview = false;
                        viewEnemies.Enabled = true;
                        viewEnemies.Show();
                        viewEnemies.DroppedDown = true;
                        viewEnemies.Focus();
                    }
                    break;

                //To attack
                case 'K':
                case 'k':
                    if (game.Map.enemiesArr.Length == 0) // if there are no enemies, break
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < game.Map.enemiesArr.Length; i++)
                        {
                            // attack first attackable enemy in enemy array
                            if (game.Map.Hero.CheckRange(game.Map.enemiesArr[i]))
                            {
                                game.Map.Hero.Attack(game.Map.enemiesArr[i]);

                                game.Map.MoveEnemies();

                                interactionMsgs.Visible = true;
                                interactionMsgs.Text = $"Successful hit {game.Map.enemiesArr[i].GetType().Name} was dealt {game.Map.Hero.Damage} damage.";
                                interactionMsgs.Text += $"\n{game.Map.enemiesArr[i].GetType().Name} is now on {game.Map.enemiesArr[i].HP} HP!";

                                if (game.Map.enemiesArr[i].IsDead())
                                {
                                    interactionMsgs.Text = "You killed an enemy!";


                                    playerScore++;
                                }
                                    //First enemy found.
                                break;  
                            }

                            else
                            {
                                interactionMsgs.Text = "Attack did not hit...";
                            }
                        }

                    }

                    DrawMap();

                    break;

                //Pickup
                case 'P':
                case 'p':

                    if (game.Map.arrOfItems[viewItems.SelectedIndex] == null)
                    {
                        break;
                    }
                    else
                    {
                        if (game.Map.Hero.CheckRange((Gold)game.Map.arrOfItems[viewItems.SelectedIndex]))
                        {

                            int firstAmount = game.Map.Hero.Wallet;

                            game.Map.Hero.PickUp((Gold)game.Map.arrOfItems[viewItems.SelectedIndex]);

                            int secAmount = game.Map.Hero.Wallet;

                            game.Map.arrOfItems[viewItems.SelectedIndex].acquired = true;


                            ItemMessages.Text = $"Alright! you picked up {secAmount - firstAmount} gold!";


                            if (game.Map.arrOfItems[viewItems.SelectedIndex].acquired == true)
                            {
                                itemSelected.Text = "none";
                            }

                        }

                        else
                        {
                            ItemMessages.Text = $"Try moving closer or selecting \nthe item you wish to pick up";
                        }

                        game.Map.UpdateMap();
                    }


                    break;
                case 'i':
                case 'I':
                    if (!viewItems.Visible)
                    {
                        this.KeyPreview = false;
                        viewItems.Enabled = true;
                        viewItems.Show();
                        viewItems.DroppedDown = true;
                        viewItems.Focus();
                    }
                    break;

            }

            game.Map.UpdateMap();
            //HideText();
            GDiffCheck();

            DrawMap();
        }

        private void GDiffCheck()
        {
            int newAmount = game.Map.Hero.Wallet;
            int diff = newAmount - playerGold;

            if (diff < 0)
            {
                ItemMessages.Visible = true;
                ItemMessages.Text = $"Purchased {game.Map.Hero.Weapon} have fun!";
            }

            else if (diff != 0)
            {
                ItemMessages.Visible = true;
                ItemMessages.Text = $"{diff} gold has been acquired.";
            }


        }

        private void msg_TextChanged(object sender, EventArgs e)
        {

        }

        private void enemyDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (enemySelected == null)
            {
                enemySelected.Text = "You have slayed all the enemies.";
            }

            else if (enemySelected.Text != null)
            {
                if (viewEnemies.SelectedItem != null)
                {
                    enemySelected.Text = viewEnemies.SelectedItem.ToString();
                }

            }

            //Brings the window to the front.
            this.Focus();
            //Re-Enable the user's controls.
            this.KeyPreview = true;

            viewEnemies.Hide();
        }

        private void itemDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (itemSelected == null)
            {
                itemSelected.Text = "No weapons remaining!";
            }

            else if (itemSelected.Text != null)
            {
                if (viewItems.SelectedItem != null)
                {
                    itemSelected.Text = viewItems.SelectedItem.ToString();
                }
            }

            this.Focus();
            this.KeyPreview = true;

            viewItems.Hide();
        }

        private void itemOneButton_Click(object sender, EventArgs e)
        {
            //Can Buy Method
            if (game.Map.shop.CanBuy(game.Map.shop.WeaponsArray[0].Cost))
            {
                game.Map.shop.Buy(game.Map.shop.WeaponsArray[0].Cost);

                ItemMessages.Text = $"You purchased a {game.Map.shop.WeaponsArray[0]}";

                DrawMap();
            }

            //Cant Buy
            else
            {

                ItemMessages.Visible = true;
                ItemMessages.Text = $"Not enough gold for {game.Map.shop.WeaponsArray[0]}.";

                DrawMap();

            }

        }

        //Save
        private void saveButton_Click(object sender, EventArgs e)
        {
            stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Dungeondata.dat", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, game);

            stream.Close();

            ItemMessages.Text = "Game saved successfully.";
        }

        //Load
        private void button1_Click(object sender, EventArgs e)
        {
            stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "Dungeondata.dat", FileMode.Open, FileAccess.Read);

            game = (GameEngine)formatter.Deserialize(stream);
            game.Map.UpdateMap();
            DrawMap();

            stream.Close();

            ItemMessages.Text = "Game loaded successfully.";
        }

        private void Box_Enter(object sender, EventArgs e)
        {

        }

        private void moveControls_Click(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {

        }

        private void interactionMsgs_Click(object sender, EventArgs e)
        {

        }

        private void notificationsContainer_Enter(object sender, EventArgs e)
        {

        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void normalSize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
