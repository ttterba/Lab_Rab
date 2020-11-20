using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Квадрат : Четырехугольник
    {
        
        public Квадрат() : base()
        {
            name = ГеометрическиеФигуры.Квадрат;
        }

        public Квадрат(double pA) :base(pA, pA, pA, pA)
        {
            name = ГеометрическиеФигуры.Квадрат;
        }

        public override double GetS()
        {
            return a * a;
        }

        public override string ОписаниеФигуры
        {
            get
            {
                return "\n" + "\n>>>>>>>>> " + name.ToString() + "\n" + "Сторона квадрата = " + a +
                    "\n" + String.Format("S = {0:0.000}   P = {1}", GetS(), base.GetP());
            }
        }
    }
}
