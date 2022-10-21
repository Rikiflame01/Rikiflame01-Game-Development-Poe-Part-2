using System;
using GoblinSlayer.Classes.Tiles.Items;

namespace GoblinSlayer.Characters
{
    [Serializable]
    class Hero : Character
    {
        public Hero(int x, int y) : base(x, y, 'H', 2, 50)
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            //movement variable, if no move is possible, then it will default to idle.
            MovementEnum moveDirection = MovementEnum.IDLE;

            switch (move)
            {
                case MovementEnum.UP:
                    if (VisionArray[0].GetType() == typeof(EmptyTile)
                        || VisionArray[0].GetType() == typeof(Gold)
                        || VisionArray[0].GetType() == typeof(MeleeWeapon)
                        || VisionArray[0].GetType() == typeof(RangedWeapon))
                    {
                        moveDirection = MovementEnum.UP;
                    }
                    break;
                case MovementEnum.DOWN:
                    if (VisionArray[1].GetType() == typeof(EmptyTile)
                        || VisionArray[1].GetType() == typeof(Gold)
                        || VisionArray[1].GetType() == typeof(MeleeWeapon)
                        || VisionArray[1].GetType() == typeof(RangedWeapon))
                    {
                        moveDirection = MovementEnum.DOWN;
                    }
                    break;
                case MovementEnum.LEFT:
                    if (VisionArray[2].GetType() == typeof(EmptyTile)
                        || VisionArray[2].GetType() == typeof(Gold)
                        || VisionArray[2].GetType() == typeof(MeleeWeapon)
                        || VisionArray[2].GetType() == typeof(RangedWeapon))
                    {
                        moveDirection = MovementEnum.LEFT;
                    }
                    break;
                case MovementEnum.RIGHT:
                    if (VisionArray[3].GetType() == typeof(EmptyTile)
                        || VisionArray[3].GetType() == typeof(Gold)
                        || VisionArray[3].GetType() == typeof(MeleeWeapon)
                        || VisionArray[3].GetType() == typeof(RangedWeapon))
                    {
                        moveDirection = MovementEnum.RIGHT;
                    }
                    break;
                default:
                    moveDirection = MovementEnum.IDLE;
                    break;
            }
            return moveDirection;
        }

        public override string ToString()
        {
            //Bare Hands
            if (this.weapon == null)
            {
                return $"Player Stats:\nHealth: {this.hp}/{this.maxHP} \nEquipped: Bare Hands \nDamage: " +
                    $"{this.damage} \nWeapon Range: 1 \nWeapon Damage: 2 \nGold: {this.wallet}\n[{this.x}, {this.y}]";
            }

            //Equipped
            else if (this.weapon != null)
            {
                return $"Player Stats:\nHealth: {this.hp}/{this.maxHP} \nEquipped: {this.weapon} \nDamage: " +
                    $"{this.damage} \nWeapon Range: {this.weapon.Range} \nWeapon Damage: {this.weapon.Damage}\nWeapon Durability: " +
                    $"{this.weapon.Durability} \nGold: {this.wallet}\n[{this.x}, {this.y}]";
            }

            else
            {
                return $"x_xsomething went wrongx_x";
            }





        }
    }
}
