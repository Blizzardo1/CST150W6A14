using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14.Shapes
{
    public class Square : Shape
    {
        private int width;
        private int height;
        private Size size;

        public override string Name => "Square";
        public override double Area => size.Width * size.Height;

        private Rectangle rect;

        public Square(Control parent, Size size, Graphics graphics)
        {
            width = parent.Width;
            height = parent.Height;
            this.size = size;
            Graphics = BufferedGraphicsManager.Current.Allocate(graphics, new(0, 0, width, height));
            Parent = parent;
            CenterName();
            rect = new Rectangle((width / 2) - (size.Width / 2), (int)((height / 2) - (size.Height / 1.125)), size.Width, size.Height);
        }

        public override void Draw()
        {
            base.Draw();
            if(Fill)
                Graphics.Graphics.FillRectangle(FillColor, rect);
            else
                Graphics.Graphics.DrawRectangle(Color, rect);
        }
    }
}
