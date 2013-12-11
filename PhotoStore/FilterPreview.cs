using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoStore
{
    public partial class FilterPreview : UserControl
    {
        private bool hover = false;

        public Action<FilterPreview> onClick
        {
            set;
            get;
        }

        public bool Selected
        {
            set;
            get;
        }

        public Filter Filter
        {
            set;
            get;
        }

        public Image Image
        {
            set;
            get;
        }

        public FilterPreview()
        {
            InitializeComponent();
        }

        private void FilterPreview_Paint(object sender, PaintEventArgs e)
        {
            Brush fgBrush = Brushes.Black;
            Brush bgBrush = Brushes.White;
            Font font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
            if (hover)
            {
                font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
            }
            SizeF size = e.Graphics.MeasureString(this.Filter.GetFilterName(), font);
            if (this.Image != null)
            {
                e.Graphics.DrawImage(this.Image, 0, 0, this.Width, this.Height);
                Bitmap bmp = new Bitmap(this.Image);
                long sum = 0;
                long total = 0;
                for (int y = bmp.Height - (int)size.Height; y < bmp.Height; y++)
                {
                    for (int x = (bmp.Width / 2) - ((int)size.Width / 2); x < (bmp.Width / 2) + (size.Width / 2); x++)
                    {
                        Color col = bmp.GetPixel(x, y);
                        sum += (col.R + col.G + col.B) / 3;
                        total++;
                    }
                }
                sum /= total;
                int g = (int)(sum % 256);
                fgBrush = new SolidBrush(Color.FromArgb(255 - g, 255 - g, 255 - g));
                bgBrush = new SolidBrush(Color.FromArgb(g, g, g, g));
            }
            if(hover || this.Selected){
                e.Graphics.FillRectangle(bgBrush, (this.Width / 2) - ((int)size.Width / 2), this.Height - (int)size.Height, size.Width, size.Height);
                e.Graphics.DrawString(this.Filter.GetFilterName(), font, fgBrush, (this.Width / 2) - (size.Width / 2), this.Height - size.Height);
                Point[] pts = new Point[] { new Point(1, 0), new Point(this.Width - 1, 0), new Point(this.Width - 1, this.Height - 1), new Point(1, this.Height - 1), new Point(1, 1) };
                e.Graphics.DrawLines(new Pen(Brushes.White, 1), pts);
            }
        }

        private void FilterPreview_MouseEnter(object sender, EventArgs e)
        {
            hover = true;
            this.Invalidate();
        }

        private void FilterPreview_MouseLeave(object sender, EventArgs e)
        {
            hover = false;
            this.Invalidate();
        }

        private void FilterPreview_Enter(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FilterPreview_Leave(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void FilterPreview_Click(object sender, EventArgs e)
        {
            this.onClick(this);
        }
    }
}
