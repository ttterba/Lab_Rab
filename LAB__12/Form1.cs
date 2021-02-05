using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LAB__12
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

        float d, z, value_e, value_y;
        double A;

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value_y = System.Convert.ToSingle(textBoxY.Text);
                A = ComputeValue(d, z, value_e, value_y);
                Text = GetStringResult(A);
            }
            catch
            {
                Text = "ERROR";
            }
        }

        private void textBoxE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                value_e = System.Convert.ToSingle(textBoxE.Text);
                A = ComputeValue(d, z, value_e, value_y);
                Text = GetStringResult(A);
            } catch
            {
                Text = "ERROR";
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            d = e.X;
            z = e.Y;
            A = ComputeValue(d, z, value_e, value_y);
            Text = GetStringResult(A);

            textBoxD.Text = e.X.ToString();
            textBoxZ.Text = e.Y.ToString();

        }


        double ComputeValue(float d, float z, float e, float y) 
        {
            double result = -d * z / Math.Sqrt(Math.Abs(e)) + Math.Abs(Math.Sin(e) + Math.Cos(y));
            return result;
        }

        string GetStringResult(double num)
        {
            if (Double.IsInfinity(num) || Double.IsNaN(num))
            {
                return "ERROR";
            }
            else
            {
                return string.Format("A = {0:0.00}", num);
            }
        }
    }
}
