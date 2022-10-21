using System;
using static GoblinSlayer.Classes.Tiles.Items.MeleeWeapon;
using static GoblinSlayer.Classes.Tiles.Items.RangedWeapon;

namespace GoblinSlayer.Classes.Tiles.Items
{
    [Serializable]
    class Shop
    {
        public enum ShopWeaponTypes
        {
            Melee,
            Ranged,
        }

        private Random rnd;

        private Weapon[] weaponsArr = new Weapon[3];

        private Character buyer;

        private readonly int differentWeapons = Enum.GetNames(typeof(ShopWeaponTypes)).Length;

        public Weapon[] WeaponsArray
        {
            get { return weaponsArr; }
            set { weaponsArr = value; }
        }


        public Shop(Character hero)
        {
            buyer = hero;

            for (int i = 0; i < weaponsArr.Length; i++)
            {
                weaponsArr[i] = RandomWeapon();

                while (i != 0 && weaponsArr[i] == weaponsArr[i - 1])
                {
                    weaponsArr[i] = RandomWeapon();
                }

            }
        }

        public Weapon RandomWeapon()
        {
            Item weapon;

            switch (RandomWeaponType())
            {
                case ShopWeaponTypes.Melee:
                
                    switch (rnd.Next(0, Enum.GetNames(typeof(MeleeTypes)).Length))
                    {
                        case (int)MeleeTypes.DAGGER: 
                            weapon = new MeleeWeapon(MeleeTypes.DAGGER);
                            break;

                        case (int)MeleeTypes.LONGSWORD:
                            weapon = new MeleeWeapon(MeleeTypes.LONGSWORD);
                            break;

                        default:
                            weapon = null;
                            break;
                    }
                    break;
                case ShopWeaponTypes.Ranged:
                    switch (rnd.Next(0, Enum.GetNames(typeof(RangedTypes)).Length))
                    {
                        case (int)RangedTypes.RIFLE:
                            weapon = new RangedWeapon(RangedTypes.RIFLE);
                            break;

                        case (int)RangedTypes.LONGBOW:
                            weapon = new RangedWeapon(RangedTypes.LONGBOW);
                            break;

                        default:
                            weapon = null;
                            break;
                    }
                    break;
                default:
                    return null;
            }

            return (Weapon)weapon;

        }

        public ShopWeaponTypes RandomWeaponType()
        {
            rnd = new Random();
            int num = rnd.Next(0, differentWeapons);

            if (num == (int)ShopWeaponTypes.Melee)
            {
                return ShopWeaponTypes.Melee;
            }
            else if (num == (int)ShopWeaponTypes.Ranged)
            {
                return ShopWeaponTypes.Ranged;
            }
            else
            {
                return default;
            }
        }

        public bool CanBuy(int num)
        {
            if (buyer.Wallet >= num)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Buy(int num)
        {
            buyer.Wallet -= num;

            for (int i = 0; i < weaponsArr.Length; i++)
            {
                if (num == weaponsArr[i].Cost)
                {
                    buyer.PickUp(weaponsArr[i]);
                    buyer.Equip(weaponsArr[i]);
                    weaponsArr[i] = RandomWeapon();
                    break;
                }
            }
        }

        public string DisplayWeapon(int num)
        {
            switch (num)
            {
                case 3:
                    return $"Dagger {num}$";
                case 5:
                    return $"Longsword {num}$";
                case 6:
                    return $"Longbow {num}$";
                case 7:
                    return $"Rifle {num}$";
                default:
                    return $"";

            }
        }


    }




}
