using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day23_3
{
    public partial class Form1 : Form
    {
        public enum Tools
        {
            PEN = 1, TEXT, LINE, ELLIPSE, NULL = 0
        }
        public enum Colors
        {
            RED = 1, BLUE, YELLOW, GREEN, DEFAULT, NULL = 0
        }
        public Form1()
        {
            InitializeComponent();
        }
        Tools currentTool;
        Colors currentColor;
        private void SetToolStripButtonsPushedState(ToolStripItem button)
        {
            foreach(ToolStripMenuItem btnItem in menuStrip1.Items)
            {
                if(btnItem == button)
                {
                    btnItem.Checked = true;
                }
                else
                {
                    btnItem.Checked = false;
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "menuItemPen":
                    currentTool = Tools.PEN;
                    statusStrip1.Items[0].Text = "Выбран карандаш"; break;
                case "menuItemText":
                    currentTool = Tools.TEXT;
                    statusStrip1.Items[0].Text = "Создание надписей"; break;
                case "menuItemLine":
                    currentTool = Tools.LINE;
                    statusStrip1.Items[0].Text = "Рисование линий"; break;
                case "menuItemEllipse":
                    currentTool = Tools.ELLIPSE;
                    statusStrip1.Items[0].Text = "Рисование эллипса"; break;
            }
            SetToolStripButtonsPushedState(e.ClickedItem);
        }

        private void BackToolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "menuItemRed":
                    currentColor = Colors.RED;
                    this.BackColor = Color.Red;
                    statusStrip1.Items[1].Text = "Цвет фона: Красный"; break;
                case "menuItemBlue":
                    currentColor = Colors.BLUE;
                    this.BackColor = Color.Blue;
                    statusStrip1.Items[1].Text = "Цвет фона: Синий"; break;
                case "menuItemYellow":
                    currentColor = Colors.YELLOW;
                    this.BackColor = Color.Yellow;
                    statusStrip1.Items[1].Text = "Цвет фона: Желтый"; break;
                case "menuItemGreen":
                    currentColor = Colors.GREEN;
                    this.BackColor = Color.Green;
                    statusStrip1.Items[1].Text = "Цвет фона: Зеленый"; break;
                case "menuItemDefault":
                    currentColor = Colors.DEFAULT;
                    this.BackColor = Color.White;
                    statusStrip1.Items[1].Text = "Цвет фона: Стандартный"; break;
            }
            SetToolStripButtonsPushedState(e.ClickedItem);
        }
    }
}
