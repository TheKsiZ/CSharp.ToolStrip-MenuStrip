using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day23
{
    public partial class Form4 : Form
    {
        Pen pen = new Pen(Color.Black, 3);
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(int i)
        {
            switch (i)
            {
                case 0:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    break;
                case 1:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    break;
                case 2:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    break;
                case 3:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                    break;
                case 4:
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                    break;
            }
            InitializeComponent();
        }
        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            
            Point point = new Point(30, 30);
            Point point2 = new Point(150, 150);
            e.Graphics.DrawLine(pen, point, point2);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
