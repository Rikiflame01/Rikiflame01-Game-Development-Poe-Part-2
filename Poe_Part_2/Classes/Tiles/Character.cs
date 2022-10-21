using System;
using GoblinSlayer.Classes.Tiles.Items;
using GoblinSlayer.Characters;

namespace GoblinSlayer
{
    [Serializable]
    abstract class Character : Tile
    {
        //Member Variables
        protected int hp;
        protected int maxHP;
        protected int damage;
        protected int wallet = 0;

        protected Weapon weapon;

        public Weapon Weapon
        {
            get { return weapon; }
        }

        //Public Accessors
        public int Wallet
        {
            get { return wallet; }
            set { wallet = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public Tile[] VisionArray
        {
            get { return visionArray; }
            set { visionArray = value; }
        }

        // character vision array: north, south, west, east; respectively.
        private Tile[] visionArray = new Tile[4];


        //movement will default to idle.
        public enum MovementEnum
        {
            // IDLE = no movement
            IDLE,
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        //Character Methods
        public Character(int x, int y, char symbol, int damage, int maxHP) : base(x, y, symbol)
        {
            this.damage = damage;
            this.maxHP = maxHP;
            this.hp = maxHP;
        }

        public void PickUp(Gold item)
        {
            if (item.GetType() == typeof(Gold))
            {
                Random rnd = new Random();
                wallet += rnd.Next(1, item.MaxGoldNum + 1);
                item.acquired = true;
            }
        }

        //weapon overload
        public void PickUp(Weapon item)
        {
            if (item.GetType() == typeof(Weapon))
            {
                item.acquired = true;
            }
        }

        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;

        }

        //Attacks a target and decreases it's health by the attacking character’s damage.
        public virtual void Attack(Character target)
        {
            //unequipped
            if (this.weapon == null)
            {
                target.HP -= this.damage;
            }

            //equipped
            else if (this.weapon != null)
            {
                target.HP -= this.weapon.Damage;
                this.weapon.Durability -= 1;

                if (this.weapon.Durability == 0)
                {
                    this.weapon = null;
                }

            }

            if (this.GetType() == typeof(Mage) && target.IsDead())
            {
                this.wallet += target.wallet; //gold will be picked up by the mage.
            }

            else if (target.IsDead())
            {
                if (target.weapon != null) //if there is a weapon, it is taken.
                {
                    this.weapon = target.weapon;
                }

                this.wallet += target.wallet;
            }
        }

        //Checks if the character is dead.
        public bool IsDead()
        {
            if (this.hp <= 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //Checks if a target is in range of a character barehanded range is always 1, but this will be extended
        //with weapon types. It determines distance via the DistanceTo()
        //method and returns true or false
        public virtual bool CheckRange(Character target)
        {
            bool canAttack = false;

            // barehand range
            if (weapon == null)
            {
                if (DistanceTo(target) == 1 || DistanceTo(target) == 0)
                {
                    canAttack = true;
                }
            }

            else if (weapon.GetType() == typeof(MeleeWeapon))
            {
                if (DistanceTo(target) == 1 || DistanceTo(target) == 0)
                {
                    canAttack = true;
                }
            }

            //Weapon class 'range' ranges.
            else if (weapon.GetType() == typeof(RangedWeapon))
            {

                bool checkDiags(Character weaponTarget, int range)
                {
                    //Diagonal range is 2 units..

                    //e.g. :
                    //
                    //    xxS
                    //    xHx
                    //    xxx

                    // To get fom H to 'S' it take two units of movement.

                    bool isInRange = true;

                    //Won't be able to attack if the range is just outside the horizontal and vertical bounds.
                    if (Math.Abs(this.Y - weaponTarget.Y) == range + 1 || Math.Abs(this.X - weaponTarget.X) == range + 1)
                    {
                        isInRange = false;
                    }

                    return isInRange;
                }

                //LongBow
                if (this.weapon.Range == 2)
                {
                    if (DistanceTo(target) <= 2)
                    {
                        canAttack = true;
                    }

                    else if (DistanceTo(target) == 3)
                    {
                        if (checkDiags(target, this.weapon.Range + 1))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 4)
                    {
                        if (checkDiags(target, this.weapon.Range + 2))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else
                    {
                        canAttack = false;
                    }
                }

                //Rifle
                else if (this.weapon.Range == 3)
                {
                    if (DistanceTo(target) <= this.weapon.Range)
                    {
                        canAttack = true;
                    }

                    else if (DistanceTo(target) == 4)
                    {
                        if (checkDiags(target, this.weapon.Range + 1))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 5)
                    {
                        if (checkDiags(target, this.weapon.Range + 2))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }

                    else if (DistanceTo(target) == 6)
                    {
                        if (checkDiags(target, this.weapon.Range + 3))
                        {
                            canAttack = true;
                        }
                        else
                        {
                            canAttack = false;
                        }
                    }
                }
            }

            else
            {
                canAttack = false;
            }

            return canAttack;
        }

        public virtual bool CheckRange(Gold target)
        {
            bool canPickup;
            // barehand range
            if (DistanceToItem(target) == 1)
            {
                canPickup = true;
            }

            else
            {
                canPickup = false;
            }

            return canPickup;
        }

        public int DistanceTo(Character target)
        {
            //The targets x and y values are subtracted from the characters x and y values and make it positive.
            //Calculates the distance via addition from there.

            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance);
            }

            return calcDistance(this.x, target.x) + calcDistance(this.y, target.y);
        }

        // overload for items 
        public int DistanceToItem(Tile target)
        {
            int calcDistance(int origin, int destination)
            {
                int distance = destination - origin;
                return Math.Abs(distance);
            }
            return calcDistance(this.x, target.X) + calcDistance(this.y, target.Y);
        }




        public void Move(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.IDLE:
                    break;
                case MovementEnum.UP:
                    this.x -= 1;
                    break;
                case MovementEnum.DOWN:
                    this.x += 1;
                    break;
                case MovementEnum.LEFT:
                    this.y -= 1;
                    break;
                case MovementEnum.RIGHT:
                    this.y += 1;
                    break;
            }
        }

        public abstract MovementEnum ReturnMove(MovementEnum move = MovementEnum.IDLE);
        //Defined by the Character subclasses. The method returns a
        //direction of movement based on how the character should move, based on
        //the validity of that move against a Character’s vision array.

        public abstract override string ToString();
        //defined in char subclasses.
    }
}
