﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day23_2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.MdiParent = this;
            m.Show();
        }
    }
}
