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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2(toolStripComboBox1.SelectedIndex);
            m.MdiParent = this;
            m.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3(toolStripComboBox1.SelectedIndex);
            m.MdiParent = this;
            m.Show();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form4 m = new Form4(toolStripComboBox1.SelectedIndex);
            m.MdiParent = this;
            m.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
