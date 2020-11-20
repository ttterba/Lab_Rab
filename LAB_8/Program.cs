using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_8
{
    public enum ГеометрическиеФигуры
    {
        Четырехугольник,
        Треугольник,
        Квадрат,
        Ромб,
        Не_определено
    }

    public enum ТипыТреугольников
    {
        Равнобедренный,
        Равносторонний,
        Прямоугольный,
        Разносторонний
    }

    class Program
    {
        static void Main(string[] args)
        {
            Геометрия geo1 = new Геометрия();
            
            Треугольник t2 = new Треугольник(3, 4, 5);

            Четырехугольник c1 = new Четырехугольник();
            Четырехугольник c2 = new Четырехугольник(5, 4, 3, 6);

            Квадрат k2 = new Квадрат(8);

            Ромб r2 = new Ромб(6, 150);

            Console.WriteLine(geo1.ОписаниеФигуры);

            Console.WriteLine(t2.ОписаниеФигуры);

            Console.WriteLine(c1.ОписаниеФигуры);
            Console.WriteLine(c2.ОписаниеФигуры);

            Console.WriteLine(k2.ОписаниеФигуры);

            Console.WriteLine(r2.ОписаниеФигуры);

            Console.ReadKey();
        }
    }
}
