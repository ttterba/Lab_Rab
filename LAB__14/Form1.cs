using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB__14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Лабораторная 14";
            CenterToScreen();
            toolStripComboBoxA.SelectedIndex = 0;
            toolStripComboBoxB.SelectedIndex = 0;
            currentCheckedItem = toolStripMenuItemEq1;
            currentCheckedItem.Checked = true;
        }


        //ЗАДАНИЕ 1.
        private void buttonCalc1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(toolStripTextBoxX.Text);
                double y = Convert.ToDouble(toolStripTextBoxY.Text);
                double z = Convert.ToDouble(toolStripTextBoxZ.Text);
                double a = Convert.ToDouble(toolStripComboBoxA.Text);
                double b = Convert.ToDouble(toolStripComboBoxB.Text);

                double ans = a * x * x + b * (y - x) + Math.Log10(a * z);
                this.Text = String.Format("Задание 1. Результат = {0:0.000}", ans);
            }
            catch
            {
                MessageBox.Show("Введите корректные значения!", "Ошибка ввода");
            }
            
        }


        //ЗАДАНИЕ 2.
        ToolStripMenuItem currentCheckedItem;

        private void toolStripMenuItemEq1_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            currentCheckedItem = toolStripMenuItemEq1;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemEq2_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            currentCheckedItem = toolStripMenuItemEq2;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemEq3_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            currentCheckedItem = toolStripMenuItemEq3;
            currentCheckedItem.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double x = e.X;
            double y = e.Y;
            
            if (currentCheckedItem == toolStripMenuItemEq1)
            {
                double ans = (y - Math.Sqrt(x)) / (Math.Abs(x - y));
                toolStripStatusLabelState.Text = String.Format("Задание 2. Результат = {0:0.000}", ans);
            }
            if (currentCheckedItem == toolStripMenuItemEq2)
            {
                double ans = Math.Sqrt( Math.Abs( Math.Sqrt(x) - Math.Sqrt(y) ) );
                toolStripStatusLabelState.Text = String.Format("Задание 2. Результат = {0:0.000}", ans);
            }
            if (currentCheckedItem == toolStripMenuItemEq3)
            {
                double ans = Math.Cos(Math.Pow(x, 2)) + Math.Pow(Math.Sin(y), 2);
                toolStripStatusLabelState.Text = String.Format("Задание 2. Результат = {0:0.000}", ans);
            }
        }
    }
}
