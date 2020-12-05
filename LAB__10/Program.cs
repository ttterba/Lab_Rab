using System;
using MatrixLibrary; //Подключение созданной библиотеки матрицы



namespace LAB_10
{
    class Program
    {

        static void Main(string[] args)
        {
            //Создание двух матриц
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();

            //Генерация матриц и запись в отдельные файлы
            m1.GenerateMatrix(7, 4);
            m1.SaveMatrix("Matrix1.txt");
            m2.GenerateMatrix(8, 3);
            m2.SaveMatrix("Matrix2.txt");



            //Печать матриц в консоль
            if (m1.LoadMatrix("Matrix1.txt"))
                m1.PrintMatrix();
            Console.WriteLine("\n\n");
            if (m2.LoadMatrix("Matrix2.txt"))
                m2.PrintMatrix();
            Console.WriteLine("\n\n");

            //Поиск и вывод максимального элемента в двух матрицах
            float max;
            if (m1.GetMaxValue > m2.GetMaxValue)
                max = m1.GetMaxValue;
            else
                max = m2.GetMaxValue;
            Console.WriteLine("Макс. элемент среди двух матриц: " + max.ToString("E3"));

            Console.ReadKey();
        }
    }
}
