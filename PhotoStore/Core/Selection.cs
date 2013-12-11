using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhotoStore
{
    public class Selection
    {
        public int Radius
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public Selection(int width, int height)
        {
            this.Radius = Math.Min(width, height);
            this.Width = width;
            this.Height = height;
        }

        public Selection(int radius)
        {
            this.Radius = radius;
            this.Width = Width;
            this.Height = Height;
        }
    }
}
