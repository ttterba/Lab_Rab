using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Треугольник : Геометрия
    {
        double a, b, c;

        public Треугольник()
            : base(ГеометрическиеФигуры.Треугольник)
        {
            a = 0; b = 0; c = 0;
        }

        public Треугольник(double pA, double pB, double pC)
            : base(ГеометрическиеФигуры.Треугольник)
        {
            a = pA;
            b = pB;
            c = pC;
        }

        public double GetP()
        {
            return a + b + c;
        }

        public double GetS()
        {
            double p = this.GetP() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public ТипыТреугольников GetTriangleType()
        {
            ТипыТреугольников type;
            if (a == b || b == c || a == c)
                type = ТипыТреугольников.Равнобедренный;
            else
                type = ТипыТреугольников.Разносторонний;
            if (a == b && b == c)
                type = ТипыТреугольников.Равносторонний;
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) ||
                Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) ||
                Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
                type = ТипыТреугольников.Прямоугольный;
            return type;

        }

        public string ТипТреугольника
        {
            get { return GetTriangleType().ToString(); }
        }

        public override string ОписаниеФигуры
        {
            get 
            {
                return "\n" + base.ОписаниеФигуры + "сторона 1 = " + a + ", сторона 2 = " + b + ", сторона 3 = " + c +
                    "\n" + String.Format("S = {0:0.000}   P = {1}", GetS(), GetP()) +
                    "\n" + "Тип треугольника: " + ТипТреугольника; 
            }
        }
    }
}
