using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinSlayer.Characters
{
    [Serializable]
    class Mage : Enemy
    {
        public Mage(int x, int y) : base(x, y, 'M', 5, 5)
        {
            this.wallet = 3;
        }

        //Mages have no movement.
        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return MovementEnum.IDLE;
        }

        public override bool CheckRange(Character target)
        {
            bool canAttack;

            bool checkDiagonal(Character mageTarget)
            {
                bool isInRange = true;

                //Mage range is represented as 'X' below:

                //   XXX
                //   XMX
                //   XXX

                //is the distance 2?
                if (Math.Abs(this.Y - mageTarget.Y) == 2 || Math.Abs(this.X - mageTarget.X) == 2)
                {
                    isInRange = false;
                }

                return isInRange;
            }

            if (DistanceTo(target) == 1) // I.E up, down, left, right is fine
            {
                canAttack = true;
            }

            else if (DistanceTo(target) == 2) //reach cannot be 2 units horizontally or vertically.
            {
                //check if distance is 2 horizontally and vertically
                if (checkDiagonal(target))
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


            return canAttack;
        }

    }
}
