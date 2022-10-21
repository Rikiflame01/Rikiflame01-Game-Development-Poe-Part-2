namespace GoblinSlayer
{
    partial class GameUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dungeonMap = new System.Windows.Forms.Label();
            this.statsContainer = new System.Windows.Forms.GroupBox();
            this.playerStats = new System.Windows.Forms.Label();
            this.playerHelpContainer = new System.Windows.Forms.GroupBox();
            this.moveControls2 = new System.Windows.Forms.Label();
            this.moveControls = new System.Windows.Forms.Label();
            this.viewEnemies = new System.Windows.Forms.ComboBox();
            this.enemyListContainer = new System.Windows.Forms.GroupBox();
            this.enemySelected = new System.Windows.Forms.Label();
            this.scoutedEnemyContainer = new System.Windows.Forms.GroupBox();
            this.notificationsContainer = new System.Windows.Forms.GroupBox();
            this.interactionMsgs = new System.Windows.Forms.Label();
            this.ItemMessages = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.GroupBox();
            this.normalSize = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.ShopContainer = new System.Windows.Forms.GroupBox();
            this.Shop_Item_1 = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.ItemContainer = new System.Windows.Forms.GroupBox();
            this.itemSelected = new System.Windows.Forms.Label();
            this.itemListContainer = new System.Windows.Forms.GroupBox();
            this.viewItems = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.statsContainer.SuspendLayout();
            this.playerHelpContainer.SuspendLayout();
            this.enemyListContainer.SuspendLayout();
            this.scoutedEnemyContainer.SuspendLayout();
            this.notificationsContainer.SuspendLayout();
            this.Background.SuspendLayout();
            this.ShopContainer.SuspendLayout();
            this.ItemContainer.SuspendLayout();
            this.itemListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dungeonMap
            // 
            this.dungeonMap.AutoSize = true;
            this.dungeonMap.BackColor = System.Drawing.Color.Black;
            this.dungeonMap.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dungeonMap.ForeColor = System.Drawing.Color.White;
            this.dungeonMap.Location = new System.Drawing.Point(496, 40);
            this.dungeonMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dungeonMap.Name = "dungeonMap";
            this.dungeonMap.Size = new System.Drawing.Size(134, 33);
            this.dungeonMap.TabIndex = 0;
            this.dungeonMap.Text = "Dungeon";
            this.dungeonMap.Click += new System.EventHandler(this.map_Click);
            // 
            // statsContainer
            // 
            this.statsContainer.AutoSize = true;
            this.statsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.statsContainer.Controls.Add(this.playerStats);
            this.statsContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statsContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.statsContainer.Location = new System.Drawing.Point(21, 40);
            this.statsContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statsContainer.Name = "statsContainer";
            this.statsContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statsContainer.Size = new System.Drawing.Size(59, 94);
            this.statsContainer.TabIndex = 2;
            this.statsContainer.TabStop = false;
            this.statsContainer.Text = "Player";
            // 
            // playerStats
            // 
            this.playerStats.AutoSize = true;
            this.playerStats.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerStats.ForeColor = System.Drawing.Color.Snow;
            this.playerStats.Location = new System.Drawing.Point(7, 44);
            this.playerStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerStats.Name = "playerStats";
            this.playerStats.Size = new System.Drawing.Size(44, 21);
            this.playerStats.TabIndex = 0;
            this.playerStats.Text = "Stats";
            // 
            // playerHelpContainer
            // 
            this.playerHelpContainer.AutoSize = true;
            this.playerHelpContainer.BackColor = System.Drawing.Color.Black;
            this.playerHelpContainer.Controls.Add(this.moveControls2);
            this.playerHelpContainer.Controls.Add(this.moveControls);
            this.playerHelpContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playerHelpContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playerHelpContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playerHelpContainer.Location = new System.Drawing.Point(0, 707);
            this.playerHelpContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerHelpContainer.Name = "playerHelpContainer";
            this.playerHelpContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playerHelpContainer.Size = new System.Drawing.Size(1615, 162);
            this.playerHelpContainer.TabIndex = 3;
            this.playerHelpContainer.TabStop = false;
            this.playerHelpContainer.Text = "Player Controls";
            // 
            // moveControls2
            // 
            this.moveControls2.AutoSize = true;
            this.moveControls2.Font = new System.Drawing.Font("Curlz MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveControls2.ForeColor = System.Drawing.Color.White;
            this.moveControls2.Location = new System.Drawing.Point(451, 21);
            this.moveControls2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveControls2.Name = "moveControls2";
            this.moveControls2.Size = new System.Drawing.Size(126, 112);
            this.moveControls2.TabIndex = 1;
            this.moveControls2.Text = "Up:      W   \r\nDown:   S   \r\nLeft:     A   \r\nRight:   D";
            // 
            // moveControls
            // 
            this.moveControls.AutoSize = true;
            this.moveControls.Font = new System.Drawing.Font("Curlz MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveControls.ForeColor = System.Drawing.Color.White;
            this.moveControls.Location = new System.Drawing.Point(274, 35);
            this.moveControls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moveControls.Name = "moveControls";
            this.moveControls.Size = new System.Drawing.Size(159, 84);
            this.moveControls.TabIndex = 0;
            this.moveControls.Text = "Item list:  I\r\nEnemy List: M\r\nAttack enemy: K\r\n";
            this.moveControls.Click += new System.EventHandler(this.moveControls_Click);
            // 
            // viewEnemies
            // 
            this.viewEnemies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewEnemies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewEnemies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewEnemies.ForeColor = System.Drawing.Color.Black;
            this.viewEnemies.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.viewEnemies.Location = new System.Drawing.Point(7, 37);
            this.viewEnemies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewEnemies.MaxDropDownItems = 20;
            this.viewEnemies.Name = "viewEnemies";
            this.viewEnemies.Size = new System.Drawing.Size(560, 28);
            this.viewEnemies.TabIndex = 4;
            this.viewEnemies.TabStop = false;
            this.viewEnemies.SelectionChangeCommitted += new System.EventHandler(this.enemyDropdown_SelectionChangeCommitted);
            // 
            // enemyListContainer
            // 
            this.enemyListContainer.AutoSize = true;
            this.enemyListContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.enemyListContainer.Controls.Add(this.viewEnemies);
            this.enemyListContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemyListContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.enemyListContainer.Location = new System.Drawing.Point(1047, 276);
            this.enemyListContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enemyListContainer.Name = "enemyListContainer";
            this.enemyListContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enemyListContainer.Size = new System.Drawing.Size(575, 106);
            this.enemyListContainer.TabIndex = 5;
            this.enemyListContainer.TabStop = false;
            this.enemyListContainer.Text = "Dungeon Enemies";
            // 
            // enemySelected
            // 
            this.enemySelected.AutoSize = true;
            this.enemySelected.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enemySelected.ForeColor = System.Drawing.Color.White;
            this.enemySelected.Location = new System.Drawing.Point(7, 29);
            this.enemySelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemySelected.Name = "enemySelected";
            this.enemySelected.Size = new System.Drawing.Size(129, 21);
            this.enemySelected.TabIndex = 6;
            this.enemySelected.Text = "Nothing to show";
            // 
            // scoutedEnemyContainer
            // 
            this.scoutedEnemyContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoutedEnemyContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scoutedEnemyContainer.Controls.Add(this.enemySelected);
            this.scoutedEnemyContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoutedEnemyContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.scoutedEnemyContainer.Location = new System.Drawing.Point(1047, 389);
            this.scoutedEnemyContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scoutedEnemyContainer.Name = "scoutedEnemyContainer";
            this.scoutedEnemyContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scoutedEnemyContainer.Size = new System.Drawing.Size(397, 117);
            this.scoutedEnemyContainer.TabIndex = 7;
            this.scoutedEnemyContainer.TabStop = false;
            this.scoutedEnemyContainer.Text = "Scouted enemy";
            // 
            // notificationsContainer
            // 
            this.notificationsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.notificationsContainer.Controls.Add(this.interactionMsgs);
            this.notificationsContainer.Controls.Add(this.ItemMessages);
            this.notificationsContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notificationsContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.notificationsContainer.Location = new System.Drawing.Point(1048, 105);
            this.notificationsContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notificationsContainer.Name = "notificationsContainer";
            this.notificationsContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.notificationsContainer.Size = new System.Drawing.Size(492, 164);
            this.notificationsContainer.TabIndex = 8;
            this.notificationsContainer.TabStop = false;
            this.notificationsContainer.Text = "MessageBox";
            this.notificationsContainer.Enter += new System.EventHandler(this.notificationsContainer_Enter);
            // 
            // interactionMsgs
            // 
            this.interactionMsgs.AutoSize = true;
            this.interactionMsgs.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.interactionMsgs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.interactionMsgs.Location = new System.Drawing.Point(7, 99);
            this.interactionMsgs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.interactionMsgs.Name = "interactionMsgs";
            this.interactionMsgs.Size = new System.Drawing.Size(93, 21);
            this.interactionMsgs.TabIndex = 1;
            this.interactionMsgs.Text = "Attack Text";
            this.interactionMsgs.Click += new System.EventHandler(this.interactionMsgs_Click);
            // 
            // ItemMessages
            // 
            this.ItemMessages.AutoSize = true;
            this.ItemMessages.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(189)))), ((int)(((byte)(47)))));
            this.ItemMessages.Location = new System.Drawing.Point(7, 39);
            this.ItemMessages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemMessages.Name = "ItemMessages";
            this.ItemMessages.Size = new System.Drawing.Size(80, 21);
            this.ItemMessages.TabIndex = 0;
            this.ItemMessages.Text = "Gold Text";
            this.ItemMessages.TextChanged += new System.EventHandler(this.msg_TextChanged);
            // 
            // Background
            // 
            this.Background.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Background.BackColor = System.Drawing.Color.Black;
            this.Background.Controls.Add(this.normalSize);
            this.Background.Controls.Add(this.ExitGame);
            this.Background.Controls.Add(this.minimize);
            this.Background.Controls.Add(this.ShopContainer);
            this.Background.Controls.Add(this.Maximize);
            this.Background.Controls.Add(this.dungeonMap);
            this.Background.Controls.Add(this.ItemContainer);
            this.Background.Controls.Add(this.scoutedEnemyContainer);
            this.Background.Controls.Add(this.itemListContainer);
            this.Background.Controls.Add(this.notificationsContainer);
            this.Background.Controls.Add(this.enemyListContainer);
            this.Background.Controls.Add(this.statsContainer);
            this.Background.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Background.Location = new System.Drawing.Point(-7, -18);
            this.Background.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Background.Name = "Background";
            this.Background.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Background.Size = new System.Drawing.Size(1623, 719);
            this.Background.TabIndex = 9;
            this.Background.TabStop = false;
            this.Background.Enter += new System.EventHandler(this.Box_Enter);
            // 
            // normalSize
            // 
            this.normalSize.BackColor = System.Drawing.Color.White;
            this.normalSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.normalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.normalSize.ForeColor = System.Drawing.Color.Black;
            this.normalSize.Location = new System.Drawing.Point(1352, 53);
            this.normalSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.normalSize.Name = "normalSize";
            this.normalSize.Size = new System.Drawing.Size(76, 34);
            this.normalSize.TabIndex = 26;
            this.normalSize.Text = "NORMAL";
            this.normalSize.UseVisualStyleBackColor = false;
            this.normalSize.Click += new System.EventHandler(this.normalSize_Click);
            // 
            // ExitGame
            // 
            this.ExitGame.BackColor = System.Drawing.Color.White;
            this.ExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitGame.ForeColor = System.Drawing.Color.Black;
            this.ExitGame.Location = new System.Drawing.Point(1491, 53);
            this.ExitGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(82, 34);
            this.ExitGame.TabIndex = 25;
            this.ExitGame.Text = "CLOSE";
            this.ExitGame.UseVisualStyleBackColor = false;
            this.ExitGame.Click += new System.EventHandler(this.ExitGame_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.White;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimize.ForeColor = System.Drawing.Color.Black;
            this.minimize.Location = new System.Drawing.Point(1295, 53);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(51, 34);
            this.minimize.TabIndex = 24;
            this.minimize.Text = "MIN";
            this.minimize.UseVisualStyleBackColor = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // ShopContainer
            // 
            this.ShopContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShopContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ShopContainer.Controls.Add(this.Shop_Item_1);
            this.ShopContainer.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShopContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ShopContainer.Location = new System.Drawing.Point(15, 414);
            this.ShopContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShopContainer.Name = "ShopContainer";
            this.ShopContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShopContainer.Size = new System.Drawing.Size(308, 97);
            this.ShopContainer.TabIndex = 15;
            this.ShopContainer.TabStop = false;
            this.ShopContainer.Text = "SHOP";
            // 
            // Shop_Item_1
            // 
            this.Shop_Item_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Shop_Item_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Shop_Item_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shop_Item_1.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Shop_Item_1.ForeColor = System.Drawing.Color.DimGray;
            this.Shop_Item_1.Location = new System.Drawing.Point(12, 31);
            this.Shop_Item_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Shop_Item_1.Name = "Shop_Item_1";
            this.Shop_Item_1.Size = new System.Drawing.Size(274, 59);
            this.Shop_Item_1.TabIndex = 0;
            this.Shop_Item_1.Text = "Shop_Item 1";
            this.Shop_Item_1.UseVisualStyleBackColor = false;
            this.Shop_Item_1.Click += new System.EventHandler(this.itemOneButton_Click);
            // 
            // Maximize
            // 
            this.Maximize.BackColor = System.Drawing.Color.White;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Maximize.ForeColor = System.Drawing.Color.Black;
            this.Maximize.Location = new System.Drawing.Point(1434, 53);
            this.Maximize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(51, 34);
            this.Maximize.TabIndex = 23;
            this.Maximize.Text = "MAX";
            this.Maximize.UseVisualStyleBackColor = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // ItemContainer
            // 
            this.ItemContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ItemContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ItemContainer.Controls.Add(this.itemSelected);
            this.ItemContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ItemContainer.Location = new System.Drawing.Point(1047, 512);
            this.ItemContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemContainer.Name = "ItemContainer";
            this.ItemContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemContainer.Size = new System.Drawing.Size(397, 85);
            this.ItemContainer.TabIndex = 8;
            this.ItemContainer.TabStop = false;
            this.ItemContainer.Text = "Item Inspection";
            // 
            // itemSelected
            // 
            this.itemSelected.AutoSize = true;
            this.itemSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.itemSelected.Font = new System.Drawing.Font("Curlz MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemSelected.ForeColor = System.Drawing.Color.White;
            this.itemSelected.Location = new System.Drawing.Point(7, 29);
            this.itemSelected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemSelected.Name = "itemSelected";
            this.itemSelected.Size = new System.Drawing.Size(129, 21);
            this.itemSelected.TabIndex = 6;
            this.itemSelected.Text = "Nothing to show";
            // 
            // itemListContainer
            // 
            this.itemListContainer.AutoSize = true;
            this.itemListContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.itemListContainer.Controls.Add(this.viewItems);
            this.itemListContainer.Font = new System.Drawing.Font("Curlz MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemListContainer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.itemListContainer.Location = new System.Drawing.Point(1047, 605);
            this.itemListContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemListContainer.Name = "itemListContainer";
            this.itemListContainer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemListContainer.Size = new System.Drawing.Size(471, 106);
            this.itemListContainer.TabIndex = 6;
            this.itemListContainer.TabStop = false;
            this.itemListContainer.Text = "Items";
            // 
            // viewItems
            // 
            this.viewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(131)))), ((int)(((byte)(116)))));
            this.viewItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(147)))));
            this.viewItems.Items.AddRange(new object[] {
            "bob ",
            "jack",
            "jill"});
            this.viewItems.Location = new System.Drawing.Point(7, 37);
            this.viewItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.viewItems.MaxDropDownItems = 20;
            this.viewItems.Name = "viewItems";
            this.viewItems.Size = new System.Drawing.Size(451, 28);
            this.viewItems.TabIndex = 4;
            this.viewItems.TabStop = false;
            this.viewItems.SelectionChangeCommitted += new System.EventHandler(this.itemDropdown_SelectionChangeCommitted);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.saveButton.Location = new System.Drawing.Point(1345, 777);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 65);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 22;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoadButton.ForeColor = System.Drawing.Color.Firebrick;
            this.LoadButton.Location = new System.Drawing.Point(1484, 777);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(120, 65);
            this.LoadButton.TabIndex = 21;
            this.LoadButton.Text = "LOAD";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1615, 869);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.playerHelpContainer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GameUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goblin Slayer.exe";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            this.statsContainer.ResumeLayout(false);
            this.statsContainer.PerformLayout();
            this.playerHelpContainer.ResumeLayout(false);
            this.playerHelpContainer.PerformLayout();
            this.enemyListContainer.ResumeLayout(false);
            this.scoutedEnemyContainer.ResumeLayout(false);
            this.scoutedEnemyContainer.PerformLayout();
            this.notificationsContainer.ResumeLayout(false);
            this.notificationsContainer.PerformLayout();
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ShopContainer.ResumeLayout(false);
            this.ItemContainer.ResumeLayout(false);
            this.ItemContainer.PerformLayout();
            this.itemListContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dungeonMap;
        private System.Windows.Forms.GroupBox statsContainer;
        private System.Windows.Forms.Label playerStats;
        private System.Windows.Forms.GroupBox playerHelpContainer;
        private System.Windows.Forms.Label moveControls;
        private System.Windows.Forms.ComboBox viewEnemies;
        private System.Windows.Forms.GroupBox enemyListContainer;
        private System.Windows.Forms.Label enemySelected;
        private System.Windows.Forms.GroupBox scoutedEnemyContainer;
        private System.Windows.Forms.GroupBox notificationsContainer;
        private System.Windows.Forms.Label ItemMessages;
        private System.Windows.Forms.GroupBox Background;
        private System.Windows.Forms.GroupBox itemListContainer;
        private System.Windows.Forms.ComboBox viewItems;
        private System.Windows.Forms.GroupBox ItemContainer;
        private System.Windows.Forms.Label itemSelected;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label interactionMsgs;
        private System.Windows.Forms.GroupBox ShopContainer;
        public System.Windows.Forms.Button Shop_Item_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label moveControls2;
        private Button ExitGame;
        private Button minimize;
        private Button Maximize;
        private Button normalSize;
    }
}