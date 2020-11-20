﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter("output.txt");
            var new_in = new StreamReader("input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            //Чтение данных из файла и инициализация массива
            //и вывод исходной матрицы
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Input matrix ***");
            int[,] mas = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Поиск и вывод минимального значения для каждого столбца
            //Находим среднее арифметическое четных элементов
            int min = 1001;
            float sp = 0;
            int k = 0;
            Console.WriteLine("*** Min column elements ***");
            for (int j = 0; j < M; j++)
            {
                min = 1001;
                for (int i = 0; i < N; i++)
                {
                    if (mas[i, j] < min)
                        min = mas[i, j];
                    if (mas[i, j] % 2 == 0)
                    {
                        sp += mas[i, j];
                        k++;
                    }
                }
                Console.Write(min + " ");
            }
            sp = sp / k;
            Console.WriteLine();

            //Вывод модифицированной матрицы
            Console.WriteLine("*** Modifed matrix ***");
            Console.WriteLine(string.Format("Avg of even numbers = {0:0.000}", sp));
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (mas[i, j] < sp)
                        Console.Write("x ");
                    else if (mas[i, j] % 2 != 0)
                        Console.Write("y ");
                    else
                        Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
