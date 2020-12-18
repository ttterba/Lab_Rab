using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB__11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            StreamReader f_in = new StreamReader("lr11_03.csv");
#if !DEBUG
            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"lr11_output.txt");
            Console.SetOut(new_out);
#endif

            List<Product> all = new List<Product>();
            
            try
            {
                String line = f_in.ReadLine();
                while ((line = f_in.ReadLine()) != null)
                {
                    all.Add(Product.Create(line));
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           

            Console.WriteLine("******************************* ЗАДАЧА 1 *******************************");
            Console.WriteLine("******* Самый дорогой продукт для каждого из 4-х поставщиков *******\n");
            float microsoft_max_price = (from p in all
                                            where (p.CompanyName == Company.Microsoft)
                                            select p.Price).Max();
            float nestle_max_price = (from p in all
                                        where (p.CompanyName == Company.Nestle)
                                        select p.Price).Max();
            float craftltd_max_price = (from p in all
                                            where (p.CompanyName == Company.Craft_Ltd)
                                            select p.Price).Max();
            float mks_max_price = (from p in all
                                      where (p.CompanyName == Company.MKS)
                                      select p.Price).Max();

            Product expensive_microsoft_product = (from p in all
                                                        where (p.CompanyName == Company.Microsoft) &&
                                                        (p.Price == microsoft_max_price) 
                                                        select p).First();
            Product expensive_nestle_product = (from p in all
                                                   where (p.CompanyName == Company.Nestle) &&
                                                   (p.Price == nestle_max_price)
                                                   select p).First();
            Product expensive_craftltd_product = (from p in all
                                                    where (p.CompanyName == Company.Craft_Ltd) &&
                                                    (p.Price == craftltd_max_price)
                                                    select p).First();
            Product expensive_mks_product = (from p in all
                                                where (p.CompanyName == Company.MKS) &&
                                                (p.Price == mks_max_price)
                                                select p).First();
            Console.WriteLine(expensive_microsoft_product + "\n");
            Console.WriteLine(expensive_nestle_product + "\n");
            Console.WriteLine(expensive_craftltd_product + "\n");
            Console.WriteLine(expensive_mks_product + "\n");

            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* ЗАДАЧА 2 *******************************");
            Console.WriteLine("******* Товар с минимальным количеством в каждой категории *******\n");
            int microsoft_outofdate_min_count = (from p in all
                                                 where (p.CompanyName == Company.Microsoft) && p.OutOfDate
                                                 select p.Count).Min();
            int microsoft_notoutofdate_min_count = (from p in all
                                                 where (p.CompanyName == Company.Microsoft) && !p.OutOfDate
                                                 select p.Count).Min();
            int nestle_outofdate_min_count = (from p in all
                                                 where (p.CompanyName == Company.Nestle) && p.OutOfDate
                                                 select p.Count).Min();
            int nestle_notoutofdate_min_count = (from p in all
                                                    where (p.CompanyName == Company.Nestle) && !p.OutOfDate
                                                    select p.Count).Min();
            int mks_outofdate_min_count = (from p in all
                                              where (p.CompanyName == Company.MKS) && p.OutOfDate
                                              select p.Count).Min();
            int mks_notoutofdate_min_count = (from p in all
                                                 where (p.CompanyName == Company.MKS) && !p.OutOfDate
                                                 select p.Count).Min();
            int craftltd_outofdate_min_count = (from p in all
                                           where (p.CompanyName == Company.Craft_Ltd) && p.OutOfDate
                                           select p.Count).Min();
            int craftltd_notoutofdate_min_count = (from p in all
                                              where (p.CompanyName == Company.Craft_Ltd) && !p.OutOfDate
                                              select p.Count).Min();
            Product microsoft_outofdate_smallest = (from p in all
                                                    where (p.CompanyName == Company.Microsoft) &&
                                                    (p.Count == microsoft_outofdate_min_count) &&
                                                    (p.OutOfDate)
                                                    select p).First();
            Product microsoft_notoutofdate_smallest = (from p in all
                                                    where (p.CompanyName == Company.Microsoft) &&
                                                    (p.Count == microsoft_notoutofdate_min_count) &&
                                                    (!p.OutOfDate)
                                                       select p).First();
            Product nestle_outofdate_smallest = (from p in all
                                                    where (p.CompanyName == Company.Nestle) &&
                                                    (p.Count == nestle_outofdate_min_count) &&
                                                    (p.OutOfDate)
                                                 select p).First();
            Product nestle_notoutofdate_smallest = (from p in all
                                                       where (p.CompanyName == Company.Nestle) &&
                                                       (p.Count == nestle_notoutofdate_min_count) &&
                                                       (!p.OutOfDate)
                                                    select p).First();
            Product mks_outofdate_smallest = (from p in all
                                                 where (p.CompanyName == Company.MKS) &&
                                                 (p.Count == mks_outofdate_min_count) &&
                                                 (p.OutOfDate)
                                              select p).First();
            Product mks_notoutofdate_smallest = (from p in all
                                                    where (p.CompanyName == Company.MKS) &&
                                                    (p.Count == mks_notoutofdate_min_count) &&
                                                    (!p.OutOfDate)
                                                 select p).First();
            Product craftltd_outofdate_smallest = (from p in all
                                              where (p.CompanyName == Company.Craft_Ltd) &&
                                              (p.Count == craftltd_outofdate_min_count) &&
                                              (p.OutOfDate)
                                              select p).First();
            Product craftltd_notoutofdate_smallest = (from p in all
                                                 where (p.CompanyName == Company.Craft_Ltd) &&
                                                 (p.Count == craftltd_notoutofdate_min_count) &&
                                                  (!p.OutOfDate)
                                                  select p).First();
            Console.WriteLine("Microsoft просроченный товар:");
            Console.WriteLine(microsoft_outofdate_smallest + "\n");
            Console.WriteLine("Microsoft не просроченный товар:");
            Console.WriteLine(microsoft_notoutofdate_smallest + "\n");
            
            Console.WriteLine("Nestle просроченный товар:");
            Console.WriteLine(nestle_outofdate_smallest + "\n");
            Console.WriteLine("Nestle не просроченный товар:");
            Console.WriteLine(nestle_notoutofdate_smallest + "\n");

            Console.WriteLine("MKS просроченный товар:");
            Console.WriteLine(mks_outofdate_smallest + "\n");
            Console.WriteLine("MKS не просроченный товар:");
            Console.WriteLine(mks_notoutofdate_smallest + "\n");

            Console.WriteLine("Craft Ltd просроченный товар:");
            Console.WriteLine(craftltd_outofdate_smallest + "\n");
            Console.WriteLine("Craft Ltd не просроченный товар:");
            Console.WriteLine(craftltd_notoutofdate_smallest + "\n");

            Console.WriteLine("\n\n");


            Console.WriteLine("******************************* ЗАДАЧА 3 *******************************");
            Console.WriteLine("******* Объем просрочки в валюте *******\n");
            float total_outofdate = (from p in all
                                   where (p.OutOfDate)
                                   select (p.Count * p.Price)).Sum();
            Console.WriteLine(String.Format("Объем просрочки в валюте: ${0}", total_outofdate));
            Console.WriteLine("\n\n\n");


            Console.WriteLine("******************************* ЗАДАЧА 4 *******************************");
            Console.WriteLine("******* Средняя цена у каждого поставщика *******\n");
            float average_microsoft = (from p in all
                                       where (p.CompanyName == Company.Microsoft)
                                       select p.Price).Average();
            float average_nestle = (from p in all
                                       where (p.CompanyName == Company.Nestle)
                                       select p.Price).Average();
            float average_mks = (from p in all
                                       where (p.CompanyName == Company.MKS)
                                       select p.Price).Average();
            float average_craftltd = (from p in all
                                       where (p.CompanyName == Company.Craft_Ltd)
                                       select p.Price).Average();
            Console.WriteLine(String.Format("Средння цена товара у Microsoft: ${0}", average_microsoft));
            Console.WriteLine(String.Format("Средння цена товара у Nestle: ${0}", average_nestle));
            Console.WriteLine(String.Format("Средння цена товара у MKS: ${0}", average_mks));
            Console.WriteLine(String.Format("Средння цена товара у Craft Ltd: ${0}", average_craftltd));

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
#endif
        }
    }
}
