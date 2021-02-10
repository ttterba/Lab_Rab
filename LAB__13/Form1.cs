using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LAB__13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxh.SelectedIndex = 0;
            listBoxc.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Z = 0;
                double X = Convert.ToDouble(textBoxX.Text, CultureInfo.InvariantCulture);
                double Y = Convert.ToDouble(textBoxY.Text, CultureInfo.InvariantCulture);
                int Num = Convert.ToInt32(textBoxNum.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int R = Convert.ToInt32(textBoxR.Text);
                double h = Convert.ToDouble(comboBoxh.Text, CultureInfo.InvariantCulture);
                double c = Convert.ToDouble(listBoxc.Text, CultureInfo.InvariantCulture);

                if (eq1.Checked)
                {
                    Z = 0; double item = 0;
                    for (int i = 0; i < Num; i++)
                    {
                        item = (i % 2 == 0) ? X : Y;
                        Z += -Math.Pow(-1, i % 2) * Math.Pow(item, i) / (i + 1);
                    }
                }
                else
                {
                    Z = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= R; j++)
                        {
                            Z += (Math.Pow(j, 2) + h * i) / (Math.Pow(i, j) + c * j);
                        }
                    }
                }
                textBoxZ.Text = String.Format("{0:0.000}", Z);
            } 
            catch
            {
                MessageBox.Show("Произошла ошибка! Введите корректные значения");
            }
            

            
        }
    }
}
