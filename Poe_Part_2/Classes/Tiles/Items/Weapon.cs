using System;

namespace GoblinSlayer.Classes.Tiles.Items
{
    [Serializable]
    abstract class Weapon : Item
    {
        //Declarations
        protected int damage;
        protected int range;
        protected int durability;
        protected int cost;
        protected string weaponType;

        #region Accessors
        public virtual int Range
        {
            get { return range; }
            set { range = value; }
        }

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Durability
        {
            get { return durability; }
            set { durability = value; }
        }

        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        #endregion

        //Constructor
        public Weapon(int x = 0, int y = 0) : base(x, y, 'W')
        {

        }
    }
}
