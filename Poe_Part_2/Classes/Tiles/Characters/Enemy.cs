using System;

namespace GoblinSlayer.Characters
{
    [Serializable]
    abstract class Enemy : Character
    {
        //random object 
        protected Random rnd = new Random();


        //Constructor 
        public Enemy(int x, int y, char symbol, int damage, int maxHP) : base(x, y, symbol, damage, maxHP)
        {

        }

        public override string ToString()
        {
            string equipState;
            bool isEquipped;

            if (this.weapon == null)
            {
                equipState = "Barehanded:";
                isEquipped = false;
            }

            else
            {
                equipState = "Equipped:";
                isEquipped = true;
            }

            if (isEquipped)
            {
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] with " +
                    $"{this.weapon.ToString()}\n({this.weapon.Durability * this.weapon.Damage})";
            }

            else
            {
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] ({this.damage} DMG)";
            }
        }
    }

}
