using System;
using System.Linq;
using GoblinSlayer.Classes.Tiles.Items;

namespace GoblinSlayer.Classes
{
    [Serializable]
    class Map
    {
        //Obect for a random enemy.
        Random rnd = new Random();

        //map dimensions
        private int mapWidth;
        private int mapHeight;

        //number of enemies
        private int enemyNum;

        private Characters.Hero hero;
        private Characters.Leader leader;

        public Shop shop;

        public Tile[,] dungeonMap;
        public Characters.Enemy[] enemiesArr;
        public Tile[] arrOfItems;

        public int Width
        {
            get { return mapWidth; }
            set { mapWidth = value; }
        }

        public int Height
        {
            get { return mapHeight; }
            set { mapHeight = value; }
        }

        public Characters.Hero Hero
        {
            get { return hero; }
            set { hero = value; }
        }

        public int EnemyNum
        {
            get { return enemyNum; }
            set { enemyNum = value; }
        }



        public Tile[,] MapTiles
        {
            get { return dungeonMap; }
            set { dungeonMap = value; }
        }

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyNum, int GDropsMax)
        {
            Random rnd = new Random();
            mapWidth = rnd.Next(minWidth, maxWidth + 1);
            mapHeight = rnd.Next(minHeight, maxHeight + 1);
            this.enemyNum = enemyNum;

            dungeonMap = new Tile[mapWidth, mapHeight];
            enemiesArr = new Characters.Enemy[enemyNum];

            //initial size of arrOfItems is set to gold drops.
            arrOfItems = new Tile[GDropsMax];

            FillMap();

            Hero = (Characters.Hero)Create(Tile.TileType.HERO);
            Create(Hero);

            shop = new Shop(Hero);


            // The enemies
            for (int i = 0; i < enemiesArr.Length; i++)
            {
                enemiesArr[i] = (Characters.Enemy)Create(Tile.TileType.ENEMY);
                Create(enemiesArr[i]);
            }

            //a random enemy becomes a leader.
            leader = (Characters.Leader)Create(Tile.TileType.LEADER);
            int leaderIndex = rnd.Next(0, enemiesArr.Length);
            enemiesArr[leaderIndex] = leader;

            //leader targets the hero.
            leader.Target = Hero;

            Create(leader);

            for (int i = 0; i < GDropsMax; i++) // GDropsMax = arrOfItems.Length
            {
                arrOfItems[i] = (Tiles.Item)Create(Tile.TileType.GOLD);
                arrOfItems[i].acquired = false;
                Create(arrOfItems[i]);
            }

            // Replaces gold in item array.
            for (int i = 0; i < arrOfItems.Length; i++)
            {
                bool replaceable;

                // more or less 1/3 chance it gets replaced 
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        replaceable = true;
                        break;
                    case 1:
                        replaceable = false;
                        break;
                    case 2:
                        replaceable = false;
                        break;
                    default:
                        replaceable = false;
                        break;
                }

                if (replaceable)
                {
                    switch (rnd.Next(0, 4))
                    {
                        case 0:
                            arrOfItems[i] = new MeleeWeapon(MeleeWeapon.MeleeTypes.DAGGER, arrOfItems[i].X, arrOfItems[i].Y);
                            break;
                        case 1:
                            arrOfItems[i] = new MeleeWeapon(MeleeWeapon.MeleeTypes.LONGSWORD, arrOfItems[i].X, arrOfItems[i].Y);
                            break;
                        case 2:
                            arrOfItems[i] = new RangedWeapon(RangedWeapon.RangedTypes.LONGBOW, arrOfItems[i].X, arrOfItems[i].Y);
                            break;
                        case 3:
                            arrOfItems[i] = new RangedWeapon(RangedWeapon.RangedTypes.RIFLE, arrOfItems[i].X, arrOfItems[i].Y);
                            break;
                        default:
                            break;
                    }
                }

                Create(arrOfItems[i]);
            }

            UpdateVision();
        }

        public void Create(Tile tile)
        {
            dungeonMap[tile.X, tile.Y] = tile;
        }

        public void MoveEnemies()
        {
            Random num = new Random();
            int directionPointer;

            for (int i = 0; i < enemiesArr.Length; i++)
            {
                if (enemiesArr[i].GetType() != typeof(Characters.Leader)) //move if the tile does not contain a leader.
                {
                    directionPointer = num.Next(0, 5); // 0 is rest, 1 is Up, 2 is Down, 3 is Left, 4 is Right
                    enemiesArr[i].Move(enemiesArr[i].ReturnMove((Character.MovementEnum)directionPointer)); //casting
                }
            }

            //as long as the leader isn't dead:
            if (!leader.IsDead())
            {
                leader.Move(leader.ReturnMove(default));
            }

        }

        public void UpdateMap()
        {
            FillMap();

            Create(Hero);
            Create(leader);

            //this will check if all the enemies are dead.
            for (int i = 0; i < enemiesArr.Length; i++)
            {
                int count = i;

                if (enemiesArr[i].IsDead())
                {
                    //This will be an array without dead enemies.
                    enemiesArr = enemiesArr.Where((source, index) => index != i).ToArray();
                }
            }

            if (leader.IsDead())
            {
                dungeonMap[leader.X, leader.Y] = new EmptyTile(leader.X, leader.Y, '.');
            }

            //items array
            for (int i = 0; i < arrOfItems.Length; i++)
            {
                dungeonMap[arrOfItems[i].X, arrOfItems[i].Y] = arrOfItems[i];
            }

            //This fills the array with enemies
            for (int i = 0; i < enemiesArr.Length; i++)
            {
                Create(enemiesArr[i]);
            }

            GetItemAtPosition(Hero);
            Create(Hero);

            //Enemies are hostile and will pick up gold.
            foreach (var enemy in enemiesArr)
            {
                if (enemy.CheckRange(Hero))
                {
                    enemy.Attack(Hero);
                }

                GetItemAtPosition(enemy);
            }

            //Mages do team damage and can damage the hero.
            foreach (var enemy in enemiesArr)
            {
                if (enemy.GetType() == typeof(Characters.Mage))
                {
                    for (int i = 0; i < enemiesArr.Length; i++)
                    {
                        if (enemy.CheckRange(enemiesArr[i]))
                        {
                            enemy.Attack(enemiesArr[i]);
                        }
                    }
                }
            }

            UpdateVision();

        }

        public void FillMap()
        {
            //Firstly generates empty tiles.
            for (int i = 0; i < dungeonMap.GetLength(0); i++)
            {
                for (int j = 0; j < dungeonMap.GetLength(1); j++)
                {
                    dungeonMap[i, j] = new EmptyTile(i, j, '.');
                }
            }

            // The border of the map array is filled with obstacles.
            for (int i = 0; i < dungeonMap.GetLength(0); i++)
            {
                for (int j = 0; j < dungeonMap.GetLength(1); j++)
                {
                    if (i == 0 || j == 0 || i == mapWidth - 1 || j == mapHeight - 1)
                    {
                        dungeonMap[i, j] = new Obstacle(i, j);
                    }
                }
            }
        }

        public void GetItemAtPosition(Character character)
        {
            for (int i = 0; i < arrOfItems.Length; i++)
            {
                if (arrOfItems[i].X == character.X && arrOfItems[i].Y == character.Y) //If at the same position as item, pick it up.
                {
                    if (arrOfItems[i].GetType() == typeof(Gold))
                    {
                        character.PickUp((Gold)arrOfItems[i]); // Pick up

                        if (arrOfItems[i].acquired) //if the item is acquired.
                        {
                            arrOfItems = arrOfItems.Where((source, index) => index != i).ToArray(); //Remove it from arrOfItems
                        }
                    }

                    else if (arrOfItems[i].GetType() == typeof(MeleeWeapon))
                    {
                        character.PickUp((MeleeWeapon)arrOfItems[i]);
                        character.Equip((MeleeWeapon)arrOfItems[i]);

                        arrOfItems = arrOfItems.Where((source, index) => index != i).ToArray();
                    }

                    else if (arrOfItems[i].GetType() == typeof(RangedWeapon))
                    {
                        character.PickUp((RangedWeapon)arrOfItems[i]);
                        character.Equip((RangedWeapon)arrOfItems[i]);

                        arrOfItems = arrOfItems.Where((source, index) => index != i).ToArray();
                    }

                }
            }
        }

        public Tile Create(Tile.TileType charType)
        {
            Random rnd = new Random();
            int randomX;
            int randomY;

            bool isOpenTile(int x, int y)
            {
                if (dungeonMap[x, y].GetType() != typeof(EmptyTile))
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

            switch (charType)
            {
                case Tile.TileType.HERO:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0));
                        randomY = rnd.Next(1, dungeonMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new Characters.Hero(randomX, randomY);

                case Tile.TileType.LEADER:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0) - 1);
                        randomY = rnd.Next(1, dungeonMap.GetLength(1) - 1);

                    } while (isOpenTile(randomX, randomY));

                    return new Characters.Leader(randomX, randomY);


                case Tile.TileType.ENEMY:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0) - 1);
                        randomY = rnd.Next(1, dungeonMap.GetLength(1) - 1);

                    } while (isOpenTile(randomX, randomY));

                    //Random type of enemy
                    int indicator = rnd.Next(0, 2);
                    switch (indicator)
                    {
                        case 0:
                            return new Characters.SwampCreature(randomX, randomY);
                        case 1:
                            return new Characters.Mage(randomX, randomY);
                        default:
                            return null;
                    }

                case Tile.TileType.GOLD:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0));
                        randomY = rnd.Next(1, dungeonMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new Gold(randomX, randomY);

                case Tile.TileType.WEAPON:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0));
                        randomY = rnd.Next(1, dungeonMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    switch (rnd.Next(0, 4))
                    {
                        case 0:
                            return new MeleeWeapon(MeleeWeapon.MeleeTypes.DAGGER, randomX, randomY);
                        case 1:
                            return new MeleeWeapon(MeleeWeapon.MeleeTypes.LONGSWORD, randomX, randomY);
                        case 2:
                            return new RangedWeapon(RangedWeapon.RangedTypes.LONGBOW, randomX, randomY);
                        case 3:
                            return new RangedWeapon(RangedWeapon.RangedTypes.RIFLE, randomX, randomY);
                        default:
                            return null;
                    }

                case Tile.TileType.EMPTY:
                    do
                    {
                        randomX = rnd.Next(1, dungeonMap.GetLength(0));
                        randomY = rnd.Next(1, dungeonMap.GetLength(1));

                    } while (isOpenTile(randomX, randomY));

                    return new EmptyTile(randomX, randomY, '.');
                default:
                    return null;
            }
        }


        public void UpdateVision()
        {
            // up
            hero.VisionArray[0] = dungeonMap[hero.X - 1, hero.Y];
            // down
            hero.VisionArray[1] = dungeonMap[hero.X + 1, hero.Y];
            //left
            hero.VisionArray[2] = dungeonMap[hero.X, hero.Y - 1];
            //right
            hero.VisionArray[3] = dungeonMap[hero.X, hero.Y + 1];

            foreach (Characters.Enemy enemy in enemiesArr)
            {
                // up
                enemy.VisionArray[0] = dungeonMap[enemy.X - 1, enemy.Y];
                // down
                enemy.VisionArray[1] = dungeonMap[enemy.X + 1, enemy.Y];
                // left
                enemy.VisionArray[2] = dungeonMap[enemy.X, enemy.Y - 1];
                // right
                enemy.VisionArray[3] = dungeonMap[enemy.X, enemy.Y + 1];

            }
        }
    }
}
