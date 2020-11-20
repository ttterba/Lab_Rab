using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Ромб : Четырехугольник
    {
        int angle;
        double d1, d2;

        public Ромб() : base()
        {
            name = ГеометрическиеФигуры.Ромб;
        }

        public Ромб(double pA, int pAngle) : base(pA, pA, pA, pA)
        {
            name = ГеометрическиеФигуры.Ромб;
            angle = pAngle;
            d1 = 2 * Math.Sin(angle / 2.0 * Math.PI / 180.0) * pA;
            d2 = d1 / Math.Tan(angle / 2.0 * Math.PI / 180.0);
        }

        public override double GetS()
        {
            return d1 * d2 / 2.0;
        }

        public override string ОписаниеФигуры
        {
            get
            {
                return "\n" + "\n>>>>>>>>> " + name.ToString() + "\n" + "Сторона ромба = " + a +
                    "\n" + String.Format("Диагональ_1 = {0:0.000}   Диагональ_2 = {1:0.000}", d1, d2) +
                    "\n" + String.Format("S = {0:0.000}   P = {1}", GetS(), base.GetP());
            }
        }
    }
}
