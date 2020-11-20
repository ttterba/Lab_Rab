using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    class Геометрия
    {
        public ГеометрическиеФигуры name;
        public Геометрия(ГеометрическиеФигуры shapeName)
        {
            name = shapeName;
        }

        public Геометрия()
        {
            name = ГеометрическиеФигуры.Не_определено;
        }

        public virtual string ОписаниеФигуры
        {
            get { return "\n>>>>>>>>> " + name.ToString() + "\n"; }
        }
    }
}
