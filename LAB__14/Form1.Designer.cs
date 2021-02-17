namespace LAB__14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemEq1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEq2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEq3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxX = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxY = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ллToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxA = new System.Windows.Forms.ToolStripComboBox();
            this.значениеBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxB = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalc1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabelState});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(644, 22);
            this.MainStatusStrip.TabIndex = 0;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEq1,
            this.toolStripMenuItemEq2,
            this.toolStripMenuItemEq3});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(121, 20);
            this.toolStripDropDownButton1.Text = "Выбор уравнения ";
            // 
            // toolStripMenuItemEq1
            // 
            this.toolStripMenuItemEq1.Name = "toolStripMenuItemEq1";
            this.toolStripMenuItemEq1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEq1.Text = "Уравнение 1";
            this.toolStripMenuItemEq1.Click += new System.EventHandler(this.toolStripMenuItemEq1_Click);
            // 
            // toolStripMenuItemEq2
            // 
            this.toolStripMenuItemEq2.Name = "toolStripMenuItemEq2";
            this.toolStripMenuItemEq2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEq2.Text = "Уравнение 2";
            this.toolStripMenuItemEq2.Click += new System.EventHandler(this.toolStripMenuItemEq2_Click);
            // 
            // toolStripMenuItemEq3
            // 
            this.toolStripMenuItemEq3.Name = "toolStripMenuItemEq3";
            this.toolStripMenuItemEq3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEq3.Text = "Уравнение 3";
            this.toolStripMenuItemEq3.Click += new System.EventHandler(this.toolStripMenuItemEq3_Click);
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(392, 17);
            this.toolStripStatusLabelState.Spring = true;
            this.toolStripStatusLabelState.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxX,
            this.toolStripTextBoxY,
            this.toolStripTextBoxZ});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.toolStripMenuItem1.Text = "Переменные";
            // 
            // toolStripTextBoxX
            // 
            this.toolStripTextBoxX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxX.Name = "toolStripTextBoxX";
            this.toolStripTextBoxX.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxX.Text = "0";
            this.toolStripTextBoxX.ToolTipText = "Переменная x";
            // 
            // toolStripTextBoxY
            // 
            this.toolStripTextBoxY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxY.Name = "toolStripTextBoxY";
            this.toolStripTextBoxY.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxY.Text = "0";
            this.toolStripTextBoxY.ToolTipText = "Переменная y";
            // 
            // toolStripTextBoxZ
            // 
            this.toolStripTextBoxZ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxZ.Name = "toolStripTextBoxZ";
            this.toolStripTextBoxZ.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxZ.Text = "0";
            this.toolStripTextBoxZ.ToolTipText = "Переменная Z";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ллToolStripMenuItem,
            this.значениеBToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItem2.Text = "Константы";
            // 
            // ллToolStripMenuItem
            // 
            this.ллToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxA});
            this.ллToolStripMenuItem.Name = "ллToolStripMenuItem";
            this.ллToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ллToolStripMenuItem.Text = "Значение a";
            // 
            // toolStripComboBoxA
            // 
            this.toolStripComboBoxA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxA.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15"});
            this.toolStripComboBoxA.Name = "toolStripComboBoxA";
            this.toolStripComboBoxA.Size = new System.Drawing.Size(121, 23);
            // 
            // значениеBToolStripMenuItem
            // 
            this.значениеBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxB});
            this.значениеBToolStripMenuItem.Name = "значениеBToolStripMenuItem";
            this.значениеBToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.значениеBToolStripMenuItem.Text = "Значение b";
            // 
            // toolStripComboBoxB
            // 
            this.toolStripComboBoxB.Items.AddRange(new object[] {
            "3",
            "6",
            "9",
            "12",
            "20"});
            this.toolStripComboBoxB.Name = "toolStripComboBoxB";
            this.toolStripComboBoxB.Size = new System.Drawing.Size(121, 23);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 37);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCalc1
            // 
            this.buttonCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc1.Location = new System.Drawing.Point(101, 117);
            this.buttonCalc1.Name = "buttonCalc1";
            this.buttonCalc1.Size = new System.Drawing.Size(108, 37);
            this.buttonCalc1.TabIndex = 4;
            this.buttonCalc1.Text = "Вычислить";
            this.buttonCalc1.UseVisualStyleBackColor = true;
            this.buttonCalc1.Click += new System.EventHandler(this.buttonCalc1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonCalc1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 181);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(21, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 149);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание 2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(294, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 38);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 56);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 51);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 55);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEq2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEq3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxX;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxY;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxZ;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ллToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxA;
        private System.Windows.Forms.ToolStripMenuItem значениеBToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCalc1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEq1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

