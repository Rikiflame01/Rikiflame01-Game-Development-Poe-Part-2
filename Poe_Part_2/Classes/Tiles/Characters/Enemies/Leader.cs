using System;
using GoblinSlayer.Classes.Tiles;
using GoblinSlayer.Classes.Tiles.Items;


namespace GoblinSlayer.Characters
{
    [Serializable]
    class Leader : Enemy
    {
        private Tile target;

        public Tile Target
        {
            get { return target; }
            set { target = value; }
        }


        public Leader(int x, int y) : base(x, y, 'L', 2, 20)
        {
            this.weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.LONGSWORD);
            this.wallet = 2;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.IDLE)
        {
            //Move direction variable
            MovementEnum moveDirection = MovementEnum.IDLE;

            int xDist = this.X - target.X;
            int yDist = this.Y - target.Y;

            Random rnd = new Random();
            // 0 = horizontal
            // 1 = veritcal
            int direction = rnd.Next(0, 2);

            switch (direction)
            {
                //{ north, south, west,east } respectively

                case 0:

                    if (yDist < -1)
                    {
                        if (VisionArray[3].GetType() == typeof(EmptyTile) 
                            || VisionArray[3].GetType() == typeof(Gold) 
                            || VisionArray[3].GetType() == typeof(MeleeWeapon) 
                            || VisionArray[3].GetType() == typeof(RangedWeapon))
                        {
                            moveDirection = MovementEnum.RIGHT;
                        }
                    }
                    else if (yDist > 1)
                    {
                        if (VisionArray[2].GetType() == typeof(EmptyTile) 
                            || VisionArray[2].GetType() == typeof(Gold) 
                            || VisionArray[2].GetType() == typeof(MeleeWeapon) 
                            || VisionArray[2].GetType() == typeof(RangedWeapon))
                        {
                            moveDirection = MovementEnum.LEFT;
                        }
                    }

                    else if (yDist == 1 || yDist == -1)
                    {
                        moveDirection = MovementEnum.IDLE;
                        goto case 1;
                    }

                    else if (yDist == 0)
                    {
                        goto case 1;
                    }

                    break;

                case 1:

                    if (xDist > -1)
                    {
                        if (VisionArray[0].GetType() == typeof(EmptyTile) 
                            || VisionArray[0].GetType() == typeof(Gold) 
                            || VisionArray[0].GetType() == typeof(MeleeWeapon) 
                            || VisionArray[0].GetType() == typeof(RangedWeapon))
                        {
                            moveDirection = MovementEnum.UP;
                        }
                    }
                    else if (xDist < 1)
                    {
                        if (VisionArray[1].GetType() == typeof(EmptyTile) 
                            || VisionArray[1].GetType() == typeof(Item) 
                            || VisionArray[1].GetType() == typeof(MeleeWeapon) 
                            || VisionArray[1].GetType() == typeof(RangedWeapon))
                        {
                            moveDirection = MovementEnum.DOWN;
                        }
                    }

                    else if (xDist == 1 || xDist == -1)
                    {
                        moveDirection = MovementEnum.IDLE;
                        goto case 0;
                    }

                    else if (xDist == 0)
                    {
                        goto case 0;
                    }

                    break;

            }

            return moveDirection;


        }


    }
}
