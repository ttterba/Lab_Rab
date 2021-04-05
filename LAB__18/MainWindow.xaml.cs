using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB__18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int N = int.Parse(textBoxN.Text);
                int K = int.Parse(textBoxK.Text);
                double p = double.Parse(textBoxP.Text);
                double y = double.Parse(textBoxY.Text);

                double sum = 0;

                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        sum += (Math.Pow(p, i) * Math.Pow(y, j)) / (i * j);
                    }
                }

                textBoxAnswer.Text = Math.Round(sum, 3).ToString();
            } 
            catch
            {
                textBoxAnswer.Text = "Ошибка ввода!";
            }
        }
    }
}
