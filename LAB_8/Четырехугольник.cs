using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Четырехугольник : Геометрия
    {
        protected double a, b, c, d;

        public Четырехугольник() 
            :base(ГеометрическиеФигуры.Четырехугольник)
        {
            a = 0; b = 0; c = 0; d = 0;
        }

        public Четырехугольник(double pA, double pB, double pC, double pD)
            :base(ГеометрическиеФигуры.Четырехугольник)
        {
            a = pA; b = pB; c = pC; d = pD;
        }

        public double GetP()
        {
            return a + b + c + d;
        }

        public virtual double GetS()
        {
            double p = GetP() / 2.0;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }

        public override string ОписаниеФигуры
        {
            get
            {
                return "\n" + base.ОписаниеФигуры + "сторона 1 = " + a + ", сторона 2 = " + b + ", сторона 3 = " + c +
                  ", сторона 4 = " + d + "\n" + String.Format("S = {0:0.000}   P = {1}", GetS(), GetP());
            }
        }
    }
}
