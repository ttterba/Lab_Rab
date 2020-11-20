using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_7
{
    class Graph
    {
        private double a, b;

        public Graph()
        {
        }

        public Graph(double pA, double pB)
        {
            a = pA; b = pB;
        }

        public static Graph createGraphFromFile()
        {
            double aa = Convert.ToDouble(Console.ReadLine());
            double bb = Convert.ToDouble(Console.ReadLine());
            return new Graph(aa, bb);
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }

        public double getIntegral()
        {
            double result;
            result = ((b * b) / (-2.0)) - ((a * a) / (-2.0));
            return result;
        }

        public double getDistance()
        {
            double distance;
            distance = Math.Sqrt(Math.Pow((b - a), 2) + Math.Pow((-b + a), 2));
            return distance;
        }

        public void Info()
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Дан график функции y=-x");
            Console.WriteLine(string.Format("a = {0:0.00}, b = {1:0.00}", a, b));
            Console.WriteLine(string.Format("Опредленный интеграл от a до b равен {0:0.00}", this.getIntegral()));
            Console.WriteLine(string.Format("Расстояние между точками (a, y(a)) и (b, y(b)) равно {0:0.00}", this.getDistance()));
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Дан график функции y=-x");
            Console.WriteLine(string.Format("a = {0:0.00}, b = {1:0.00}", a, b));
            Console.WriteLine(string.Format("Опредленный интеграл от a до b равен {0:0.00}", this.getIntegral()));
            Console.WriteLine(string.Format("Расстояние между точками (a, y(a)) и (b, y(b)) равно {0:0.00}", this.getDistance()));
            Console.WriteLine("--------------------------------------------------------------------------\n");
        }
    }
}
