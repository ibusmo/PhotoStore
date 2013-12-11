using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoStore
{
    public class Position
    {
        public int X
        {
            set;
            get;
        }

        public int Y
        {
            set;
            get;
        }

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
