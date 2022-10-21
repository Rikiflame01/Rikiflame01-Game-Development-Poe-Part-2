using System;
using GoblinSlayer.Characters;
using GoblinSlayer.Classes.Tiles.Items;

namespace GoblinSlayer.Classes
{
    [Serializable]
    class GameEngine
    {

        //Tile representations.
        private static readonly char heroTile = 'H';
        private static readonly char emptyTile = ' ';
        private static readonly char obstTile = 'X';
        private static readonly char SwampCreatureTile = 'S';
        private static readonly char mageTile = 'M';
        private static readonly char leaderTile = 'L';
        private static readonly char goldTile = '$';
        private static readonly char weaponTile = 'W';
        private static readonly char range = '•';

        private Map map;

        public Map Map
        {
            get { return map; }
        }

        public GameEngine()
        {
            map = new Map(14, 16, 18, 21, 6, 8);

        }

        public override string ToString()
        {
            string emptyMapString = string.Empty;
            char[,] asciiMap = new char[map.Width, map.Height];

            for (int i = 0; i < map.Width; i++)
            {
                for (int j = 0; j < map.Height; j++)
                {
                    if (map.MapTiles[i, j].GetType() == typeof(EmptyTile))
                    {
                        asciiMap[i, j] = emptyTile;
                    }

                    //shows the enemy ranges.
                    foreach (var enemy in map.enemiesArr)
                    {
                        //north, south, west, east
                        asciiMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y] = range;
                        asciiMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y] = range;
                        asciiMap[enemy.VisionArray[2].X, enemy.VisionArray[2].Y] = range;
                        asciiMap[enemy.VisionArray[3].X, enemy.VisionArray[3].Y] = range;

                        //The range of the mage.
                        if (enemy.GetType() == typeof(Mage))
                        {
                            asciiMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y + 1] = range; //top right
                            asciiMap[enemy.VisionArray[0].X, enemy.VisionArray[0].Y - 1] = range; //top left
                            asciiMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y + 1] = range; //bottom left
                            asciiMap[enemy.VisionArray[1].X, enemy.VisionArray[1].Y - 1] = range; //bottom right
                        }

                    }

                    if (map.MapTiles[i, j].GetType() == typeof(Obstacle))
                    {
                        asciiMap[i, j] = obstTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(Gold))
                    {
                        asciiMap[i, j] = goldTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(RangedWeapon) || map.MapTiles[i, j].GetType() == typeof(MeleeWeapon))
                    {
                        asciiMap[i, j] = weaponTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(Hero))
                    {
                        asciiMap[i, j] = heroTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(Leader))
                    {
                        asciiMap[i, j] = leaderTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(SwampCreature))
                    {
                        asciiMap[i, j] = SwampCreatureTile;
                    }

                    if (map.MapTiles[i, j].GetType() == typeof(Mage))
                    {
                        asciiMap[i, j] = mageTile;
                    }



                    emptyMapString += asciiMap[i, j];
                }

                emptyMapString += "\n";
            }

            return $"{emptyMapString}";
        }
    }
}
