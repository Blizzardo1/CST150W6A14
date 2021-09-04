using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14.Shapes
{
    public class Triangle : Shape
    {
        private int width;
        private int height;
        private Size size;

        public override string Name => "Triangle";
        public override double Area => size.Width * size.Height;

        private Point[] points;

        public Triangle(Control parent, Size size, Graphics graphics)
        {
            width = parent.Width;
            height = parent.Height;
            this.size = size;
            Graphics = BufferedGraphicsManager.Current.Allocate(graphics, new(0, 0, width, height));
            Parent = parent;
            CenterName();
            points = new Point[] {
                new((width / 2), (int)((height / 2) - (size.Height / 1.125))),
                new((width / 2) - (size.Width/2), (height / 2) + (size.Height / 2)),
                new(((width / 2) + (size.Width/2)), ((height / 2) + (size.Height / 2))),
            };
        }

        public override void Draw()
        {
            base.Draw();
            if (Fill)
                //Graphics.Graphics.FillRectangle(FillColor, new Rectangle(), size.Width, size.Height));
                Graphics.Graphics.FillPolygon(FillColor, points);
            else
                Graphics.Graphics.DrawPolygon(Color, points);
        }
    }
}
