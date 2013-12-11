using PhotoStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhotoStore.Filters
{
    public class ExampleFilter : Filter
    {
        public override string GetFilterName()
        {
            //This will show the name of filter under filter image
            return "Example Filter";
        }

        public override int GetMinimumValue(){
            //Minimum value allowed
            return 0;
        }

        public override int GetMaximumValue()
        {
            //Maximum value allowed
            return 100;
        }

        public override int GetValueStep()
        {
            //Value stepping
            return 1;
        }

        public override bool AllowDragSelection()
        {
            //Allowed drag selection
            return false;
        }

        public override Image RunFilter(BackgroundWorker bgWorker, int value, Position pos, Selection selection, Image source)
        {
            Random rd = new Random();
            Bitmap bmp = new Bitmap(source);
            for (int y = 0; y < bmp.Height;y++ )
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color col = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(rd.Next(col.R), rd.Next(col.G), rd.Next(col.B)));
                }
                bgWorker.ReportProgress((y * 100 / bmp.Height));
            }
            return bmp;
        }
    }
}
