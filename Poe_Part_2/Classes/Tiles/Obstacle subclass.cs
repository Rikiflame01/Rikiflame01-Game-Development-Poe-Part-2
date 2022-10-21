using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoblinSlayer
{
    [Serializable]
    //This will be used to create the border of the dungeon map where no
    //entity can move past.
    class Obstacle : Tile
    {
        //Constructor for subclass
        public Obstacle(int x, int y) : base(x, y, 'X')
        {

        }
    }
}
