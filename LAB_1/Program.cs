using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: \n");
            Console.WriteLine("Лабораторная работа № 1");
            Console.WriteLine("\"Разработка консольного приложения\"");
            Console.WriteLine("ФИО: Артемов Илья Дмитриевич");
            Console.WriteLine("Группа: ИНС-б-о-19-1");
            Console.WriteLine("Шифр специальности: 09.03.02");
            Console.WriteLine("Дата рождения: 17.09.2001");
            Console.WriteLine("Нас. пункт: Ставрополь");
            Console.WriteLine("Любимый предмет в школе: математика");
            Console.WriteLine("В свободное время предпочитаю заняться спортом " +
                              "почитать книги или статьи, посмотреть видео или увидеться с друзьями");

            Console.WriteLine("\n\nЗадание 2: \n");
            int a = 3, b = 5, x = 11, f = 7, i_2 = 10;
            float R_x, t = 2;
            R_x = a * b + b / t - x + f * i_2;
            Console.WriteLine("Значение R_x равно {0}", R_x);
            
            Console.ReadKey();
        }
    }
}
