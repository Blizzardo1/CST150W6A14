using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14.Shapes
{
    public class Circle : Shape
    {
        private double r = 0f;
        private int width;
        private int height;

        public override string Name => "Circle";
        public override double Area => Math.PI * (Math.Pow(r, 2));
        
        private Rectangle rect;

        public Circle(Control parent, double radius, Graphics graphics)
        {
            r = radius;
            width = parent.Width;
            height = parent.Height;
            Graphics = Graphics = BufferedGraphicsManager.Current.Allocate(graphics, new(0, 0, width, height));
            Parent = parent;
            CenterName();
            rect = new Rectangle((int)((width / 2) - (Area / 2)), (int)((height / 2) - (Area / 1.25)), (int)Area, (int)Area);
        }

        public override void Draw()
        {
            base.Draw();
            if(Fill)
                Graphics.Graphics.FillEllipse(FillColor, rect);
            else
                Graphics.Graphics.DrawEllipse(Color, rect);
        }
    }
}
