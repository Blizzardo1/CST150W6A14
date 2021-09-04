using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14.Shapes
{
    public class Polygon : Shape
    {
        private int width;
        private int height;
        private Size size;

        public override double Area => 100;//  width * height;

        Point[] points;

        public Polygon(string name, int sides, Control parent, Size size, Graphics graphics)
        {
            width = parent.Width;
            height = parent.Height;
            this.size = size;
            Graphics = BufferedGraphicsManager.Current.Allocate(graphics, new(0, 0, width, height));
            Parent = parent;
            CenterName();
            points = GeneratePoints(sides, width, height, size);
            Name = name;
        }

        public override void Draw()
        {
            base.Draw();
            if (Fill)
                Graphics.Graphics.FillPolygon(FillColor, points);
            else
                Graphics.Graphics.DrawPolygon(Color, points);
        }
    }
}
