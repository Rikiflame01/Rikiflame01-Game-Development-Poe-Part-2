using System;

namespace GoblinSlayer
{
    //Simply denotes an empty tile
    [Serializable]
    class EmptyTile : Tile
    {
        //Constructor for subclass
        public EmptyTile(int x, int y, char symbol) : base(x, y, symbol)
        {

        }
    }
}
