using System;
using GoblinSlayer.Classes.Tiles.Items;

namespace GoblinSlayer.Characters
{
    [Serializable]
    class SwampCreature : Enemy
    {
        // Constructor
        public SwampCreature(int x, int y) : base(x, y, 'G', 1, 10)
        {
            this.weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.DAGGER);
            this.wallet = 1;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            MovementEnum moveDirection = MovementEnum.IDLE;

            switch (move)
            {
                case MovementEnum.UP:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) 
                        || VisionArray[0].GetType() == typeof(Gold) 
                        || VisionArray[0].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[0].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.UP;
                        }
                    }
                    break;

                case MovementEnum.DOWN:
                    if (VisionArray[1].GetType() == typeof(EmptyTile) 
                        || VisionArray[1].GetType() == typeof(Gold) 
                        || VisionArray[1].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[1].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.DOWN;
                        }
                    }
                    break;

                case MovementEnum.LEFT:
                    if (VisionArray[2].GetType() == typeof(EmptyTile) 
                        || VisionArray[2].GetType() == typeof(Gold) 
                        || VisionArray[2].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[2].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.LEFT;
                        }

                    }
                    break;
                case MovementEnum.RIGHT:
                    if (VisionArray[3].GetType() == typeof(EmptyTile) 
                        || VisionArray[3].GetType() == typeof(Gold) 
                        || VisionArray[3].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[3].GetType() != typeof(Hero))
                        {
                            moveDirection = MovementEnum.RIGHT;
                        }

                    }
                    break;
            }

            return moveDirection;
        }


    }
}
