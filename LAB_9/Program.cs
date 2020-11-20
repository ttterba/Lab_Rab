using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    public interface IChangable
    {
        void Increase(double pPercent);
        void Decrease(double pPercent);
    }
    
    public interface IFinance
    {
        void ConvertToRubles();
        void ConvertToEuros();
        void ConvertToDollars();
    }

    public interface IDrawable
    {
        string Name { get; set; }
        void DrawObject();
    }

    public class Треугольник: IChangable, IDrawable
    {
        public Треугольник(string pType, double pSquare)
        {
            Type = pType;
            Square = pSquare;
        }
        private string Type;
        private double Square;

        public void Increase(double pPercent)
        {
            Square *= 1 + pPercent * 0.01;
        }

        public void Decrease(double pPercent)
        {
            Square *= 1 - pPercent * 0.01;
        }

        public string Name 
        { 
            get
            {
                return Type + " треугольник, S = " + Square.ToString();
            } 
            set
            {
                Type = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                (
                    "        *        \n" +
                    "      *   *      \n" +
                    "    *       *    \n" +
                    "  *           *  \n" +
                    "* * * * * * * * *\n" 
                );
            Console.WriteLine(Name);
        }
    }

    public class Четырехугольник : IChangable, IDrawable
    {
        public Четырехугольник(string pType, double pSquare)
        {
            Type = pType;
            Square = pSquare;
        }
        private string Type;
        private double Square;

        public void Increase(double pPercent)
        {
            Square *= 1 + pPercent * 0.01;
        }

        public void Decrease(double pPercent)
        {
            Square *= 1 - pPercent * 0.01;
        }

        public string Name
        {
            get
            {
                return Type + ", S = " + Square.ToString();
            }
            set
            {
                Type = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                (
                    "* * * * * * * * *\n" +
                    "*               *\n" +
                    "*               *\n" +
                    "*               *\n" +
                    "* * * * * * * * *\n"
                );
            Console.WriteLine(Name);
        }
    }

    public class Акция : IChangable, IDrawable, IFinance
    {
        public Акция(string pCompany, double pPrice)
        {
            Company = pCompany;
            Price = pPrice;
            Currency = "$";
            CurrencyID = 0;
        }
        public Акция(string pCompany, double pPrice, int pCurrencyID)
        {
            Company = pCompany;
            Price = pPrice;
            switch (pCurrencyID)
            {
                case 0: Currency = "$"; CurrencyID = 0; break;
                case 1: Currency = " EUR"; CurrencyID = 1; break;
                case 2: Currency = " RUB"; CurrencyID = 2; break;
                default: Currency = "$"; CurrencyID = 0; break;
            }
        }
        private string Company;
        private double Price;
        private string Currency;
        private int CurrencyID;

        public void Increase(double pPercent)
        {
            Price *= 1 + pPercent * 0.01;
        }

        public void Decrease(double pPercent)
        {
            Price *= 1 - pPercent * 0.01;
        }

        public string Name
        {
            get
            {
                return $"Акция компании {Company}. Цена: {Price}{Currency}";
            }
            set
            {
                Company = value;
            }
        }

        public void DrawObject()
        {
            Console.WriteLine
                (
                    "                                            *\n" +
                    "                                           * \n" +
                    "                                          *  \n" +
                    "                       *                 *   \n" +
                    "                     *   *              *    \n" +
                    "                   *       *           *     \n" +
                    "                 *           *        *      \n" +
                    "       *       *               *     *       \n" +
                    "     *   *   *                   *  *        \n" +
                    "   *       *                      *          \n" +
                    "  *                                          \n" +
                    "*                                            \n" 
                );
            Console.WriteLine(Name);
        }

        public void ConvertToRubles()
        {
            if (CurrencyID == 0)
            {
                Price *= 76.08;
            } else if (CurrencyID == 1)
            {
                Price *= 90.29;
            }
            Currency = " RUB";
            CurrencyID = 2;
        }
        public void ConvertToEuros()
        {
            if (CurrencyID == 0)
            {
                Price *= 0.84;
            } else if (CurrencyID == 2)
            {
                Price *= 0.011;
            }
            Currency = " EUR";
            CurrencyID = 1;
        }
        public void ConvertToDollars()
        {
            if (CurrencyID == 1)
            {
                Price *= 1.19;
            }
            else if (CurrencyID == 2)
            {
                Price *= 0.013;
            }
            Currency = "$";
            CurrencyID = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа №9";

            Треугольник t = new Треугольник("Равнобедренный", 46);
            t.Increase(30);
            t.Decrease(13);
            t.DrawObject();

            Console.WriteLine("\n\n\n");

            Четырехугольник r = new Четырехугольник("Ромб", 27);
            r.Increase(11);
            r.Decrease(20);
            r.DrawObject();

            Console.WriteLine("\n\n\n");

            Акция stock = new Акция("Apple", 118);
            stock.Increase(42);
            stock.Decrease(20);
            stock.DrawObject();

            stock.ConvertToRubles();
            stock.DrawObject();


            Console.ReadKey();
        }
    }
}
