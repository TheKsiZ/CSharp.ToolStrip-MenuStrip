using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace day23_2
{
    public partial class Form2 : Form
    {
        Rectangle rect = new Rectangle(100, 110, 100, 200);
        Rectangle rect2 = new Rectangle(300, 110, 100, 200);
        public Form2()
        {
            InitializeComponent();
        }
        private void MoveCircle()
        {
            lock (this)
            {
                Graphics g = this.CreateGraphics();
                Brush b1 = Brushes.Red;
                Brush b2 = SystemBrushes.Control;
                int x;
                if (Thread.CurrentThread.Name == "First")
                {
                    x = Height / 2 - 30;
                }
                else if (Thread.CurrentThread.Name == "Second")
                {
                    x = Height / 2;
                }
                else
                {
                    x = Height / 2 + 30;
                }
                for (int y = 10; y < Width - 40; y++)
                {
                    g.FillEllipse(b1, y - 10, x - 10, 20, 20);
                    Thread.Sleep(30);
                    if ((y + 10 > rect.X && y - 10 < rect.X + rect.Width) || (y + 10 > rect2.X && y - 10 < rect2.X + rect2.Width)) Invalidate();
                    else
                    {
                        Monitor.Pulse(this);
                        Monitor.Wait(this);
                    }
                    g.FillEllipse(b2, y - 10, x - 10, 20, 20);
                }
                Monitor.Pulse(this);
            }

            MessageBox.Show("Поток " + Thread.CurrentThread.Name + " завершен!");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(MoveCircle));
            thread1.Name = "First";
            Thread thread2 = new Thread(new ThreadStart(MoveCircle));
            thread2.Name = "Second";
            Thread thread3 = new Thread(new ThreadStart(MoveCircle));
            thread3.Name = "Third";
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b = Brushes.Black;
            g.FillRectangle(b, rect);
            g.FillRectangle(b, rect2);
        }
    }
}
