namespace day23_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelBackground = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelBackground});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(364, 20);
            this.toolStripStatusLabel.Text = "Не выбрано ни одного графического инструмента";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem,
            this.BackToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPen,
            this.menuItemText,
            this.menuItemLine,
            this.menuItemEllipse});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.toolStripMenuItem.Text = "Инструмент";
            this.toolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuItemPen
            // 
            this.menuItemPen.Name = "menuItemPen";
            this.menuItemPen.Size = new System.Drawing.Size(224, 26);
            this.menuItemPen.Text = "&Карандаш";
            // 
            // menuItemText
            // 
            this.menuItemText.Name = "menuItemText";
            this.menuItemText.Size = new System.Drawing.Size(224, 26);
            this.menuItemText.Text = "&Текст";
            // 
            // menuItemLine
            // 
            this.menuItemLine.Name = "menuItemLine";
            this.menuItemLine.Size = new System.Drawing.Size(224, 26);
            this.menuItemLine.Text = "&Линия";
            // 
            // menuItemEllipse
            // 
            this.menuItemEllipse.Name = "menuItemEllipse";
            this.menuItemEllipse.Size = new System.Drawing.Size(224, 26);
            this.menuItemEllipse.Text = " &Эллипс";
            // 
            // toolStripStatusLabelBackground
            // 
            this.toolStripStatusLabelBackground.Name = "toolStripStatusLabelBackground";
            this.toolStripStatusLabelBackground.Size = new System.Drawing.Size(181, 20);
            this.toolStripStatusLabelBackground.Text = "Цвет фона: Стандартный";
            // 
            // BackToolStripMenuItem1
            // 
            this.BackToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRed,
            this.menuItemBlue,
            this.menuItemYellow,
            this.menuItemGreen,
            this.menuItemDefault});
            this.BackToolStripMenuItem1.Name = "BackToolStripMenuItem1";
            this.BackToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.BackToolStripMenuItem1.Text = "Цвет фона";
            this.BackToolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BackToolStripMenuItem1_DropDownItemClicked);
            // 
            // menuItemRed
            // 
            this.menuItemRed.Name = "menuItemRed";
            this.menuItemRed.Size = new System.Drawing.Size(224, 26);
            this.menuItemRed.Text = "&Красный";
            // 
            // menuItemBlue
            // 
            this.menuItemBlue.Name = "menuItemBlue";
            this.menuItemBlue.Size = new System.Drawing.Size(224, 26);
            this.menuItemBlue.Text = "&Синий";
            // 
            // menuItemYellow
            // 
            this.menuItemYellow.Name = "menuItemYellow";
            this.menuItemYellow.Size = new System.Drawing.Size(224, 26);
            this.menuItemYellow.Text = " &Желтый";
            // 
            // menuItemGreen
            // 
            this.menuItemGreen.Name = "menuItemGreen";
            this.menuItemGreen.Size = new System.Drawing.Size(224, 26);
            this.menuItemGreen.Text = " &Зеленый";
            // 
            // menuItemDefault
            // 
            this.menuItemDefault.Name = "menuItemDefault";
            this.menuItemDefault.Size = new System.Drawing.Size(224, 26);
            this.menuItemDefault.Text = " &Стандартный";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemPen;
        private System.Windows.Forms.ToolStripMenuItem menuItemText;
        private System.Windows.Forms.ToolStripMenuItem menuItemLine;
        private System.Windows.Forms.ToolStripMenuItem menuItemEllipse;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBackground;
        private System.Windows.Forms.ToolStripMenuItem BackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemRed;
        private System.Windows.Forms.ToolStripMenuItem menuItemBlue;
        private System.Windows.Forms.ToolStripMenuItem menuItemYellow;
        private System.Windows.Forms.ToolStripMenuItem menuItemGreen;
        private System.Windows.Forms.ToolStripMenuItem menuItemDefault;
    }
}

