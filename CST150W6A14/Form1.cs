using CST150W6A14.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST150W6A14
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Shape shape;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            fillRbtn.Checked = true;
            longDateRbtn.Checked = true;
            g = canvasPnl.CreateGraphics();
            timer = new Timer { Interval = 18 };
            timer.Tick += Timer_Tick;
            shapeLstBx.Items.AddRange(new object[] {
                new Circle(canvasPnl, 8, g),
                new Square(canvasPnl, new(150, 150), g),
                new Triangle(canvasPnl, new(250, 160), g),
                new Polygon("Pentagon", 5, canvasPnl, new Size(150,150), g), // Pentagon
                new Polygon("Hexagon", 6, canvasPnl, new Size(150,150), g), // Hexagon
                new Polygon("Octagon", 8, canvasPnl, new Size(150,150), g), // Octagon
                new Polygon("Dekahexagon", 16, canvasPnl, new Size(150,150), g), // Dekahexagon
            });
            shapeLstBx.SelectedIndex = 0;
            dateChk_CheckedChanged(this, EventArgs.Empty);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            shape.Fill = fillRbtn.Checked;
            shape.ShowDate = dateChk.Checked;
            shape.ShowName = nameChk.Checked;
            shape.LongDateFormat = longDateRbtn.Checked;

            shape.Update();
            shape.Draw();
            shape.Swap();
        }

        private void dateChk_CheckedChanged(object sender, EventArgs e)
        {
            dateFormatGrp.Enabled = dateChk.Checked;
        }

        private void shapeLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (shapeLstBx.SelectedItem is Shape s)
            {
                shape = s;
            };
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            g.Clear(Color.FromKnownColor(KnownColor.Control));
        }
    }
}
