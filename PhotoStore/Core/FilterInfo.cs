using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhotoStore
{
    public class FilterInfo
    {
        public Filter Filter
        {
            get;
            set;
        }

        public Image Image
        {
            get;
            set;
        }

        public int Value
        {
            get;
            set;
        }

        public Position Position
        {
            get;
            set;
        }

        public Selection Selection
        {
            get;
            set;
        }

        public Action<FilterInfo> Callback
        {
            get;
            set;
        }
    }
}
