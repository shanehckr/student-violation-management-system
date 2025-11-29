using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOffensePage
{
    internal class CustomizeRoundedPanel : Panel
    {
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.Black;
        public float BorderSize { get; set; } = 2f;

        public CustomizeRoundedPanel()
        {
            this.DoubleBuffered = true; // smoother rendering
            this.BackColor = Color.White;
            this.MinimumSize = new Size(20, 20);
        }
 
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
            {
                // Fill background
                using (Brush brush = new SolidBrush(this.BackColor))
                    e.Graphics.FillPath(brush, path);

                // Draw border
                using (Pen pen = new Pen(BorderColor, BorderSize))
                    e.Graphics.DrawPath(pen, path);

                // Set the region so child controls respect rounded corners
                this.Region = new Region(path);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate(); // forces repaint
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
 


