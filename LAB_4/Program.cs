using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input3.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            //Считывание входных данных и создание массива
            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            double[] mas = new double[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToDouble(str_elem[i]);
            }

            //Подсчет среднего арифмитического, произведения чисел, меньших 50 и их кол-во
            double p = 1, s = 0, sa = 0; int counter = 0;
            for (int i = 0; i < N; i++)
            {
                s += mas[i];
                if (mas[i] < 50)
                {
                    p *= mas[i];
                    counter++;
                }
            }
            sa = 1.0 * s / N;

            //Вывод произведения чисел, меньших 50 (если таких нет - то 0)
            if (counter == 0)
            {
                Console.WriteLine("0");
            } else
            {
                Console.WriteLine(p);
            }

            //Вывод всех числе, больших среднего арифмитического
            for (int i = 0; i < N; i++)
            {
                if (mas[i] >= sa)
                    Console.Write(mas[i] + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
