using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14.Shapes
{
    public abstract class Shape
    {
        private DateTime dateTime;
        
        protected BufferedGraphics Graphics { get; set; }

        protected Pen Color { get; set; }

        protected Brush FillColor => Color.Brush;

        protected Control Parent { get; set; }
        
        protected PointF NamePosition { get; set; }

        protected PointF DatePosition { get; set; }

        public virtual string Name { get; protected set; }
        
        public abstract double Area { get; }
        
        public bool Fill { get; set; }

        public bool ShowDate { get; set; }

        public bool LongDateFormat { get; set; }

        public bool ShowName { get; set; }

        protected void CenterName()
        {
            SizeF sz = Graphics.Graphics.MeasureString(Name, Parent.Font);
            NamePosition = new((Parent.Width / 2) - (sz.Width / 2), (Parent.Height / 2) + 128);
        }

        protected void CenterDate()
        {
            SizeF sz = Graphics.Graphics.MeasureString($"{(LongDateFormat ? $"{dateTime:F}" : $"{dateTime:d}")}", Parent.Font);
            DatePosition = new((Parent.Width / 2) - (sz.Width / 2), (Parent.Height / 2) + 108);
        }

        protected Point[] GeneratePoints(int sides, int canvasWidth, int canvasHeight, Size size)
        {
            int x = (canvasWidth / 2) - (size.Width/16);
            int y = (canvasHeight / 2) - (size.Height / 4);
            Point[] points = new Point[sides];
            for (int i = 0; i < sides; i++)
            {
                points[i] = new((int)(x + Area * Math.Cos(2 * Math.PI * i / sides)), (int)(y + Area * Math.Sin(2 * Math.PI * i / sides)));
            }
            return points;
        }

        public virtual void Draw()
        {
            Graphics.Graphics.Clear(System.Drawing.Color.CornflowerBlue);
            if(ShowName)
                Graphics.Graphics.DrawString($"{Name}", Parent.Font, Brushes.White, NamePosition);

            if(ShowDate)
                Graphics.Graphics.DrawString($"{(LongDateFormat ? $"{dateTime:F}" : $"{dateTime:d}")}", Parent.Font, Brushes.White, DatePosition);
        }

        public virtual void Update()
        {
            dateTime = DateTime.Now;
            CenterDate();
            CenterName();
        }

        public void Swap()
        {
            Graphics.Render();
        }

        public Shape()
        {
            Color = new (Brushes.Red, 3);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
