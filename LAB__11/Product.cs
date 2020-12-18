using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LAB__11
{
    enum Company
    {
        Microsoft,
        MKS,
        Nestle,
        Craft_Ltd,
    }

    class Product
    {
        String ID { get; set; }
        String ProductName { get; set; }
        public Company CompanyName{ get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public Boolean OutOfDate { get; set; }

        public static Product Create(String str)
        {
            Product p = new Product();
            //string[] e = str.Split(',');
            string[] e = Regex.Split(str, ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");
            p.ID = e[0].Trim();
            p.ProductName = e[1].Trim();
            String tmp = e[2].Trim();
            if (tmp == "Microsoft")
                p.CompanyName = Company.Microsoft;
            else if (tmp == "MKS")
                p.CompanyName = Company.MKS;
            else if (tmp == "Nestle")
                p.CompanyName = Company.Nestle;
            else
                p.CompanyName = Company.Craft_Ltd;
            p.Price = Convert.ToSingle(e[3].TrimStart('$').Replace('.', ','));
            p.Count = Convert.ToInt32(e[4].Trim());
            p.OutOfDate = Convert.ToBoolean(e[5].Trim());

            return p;
        }

        public static String CompanyToStr(Company c)
        {
            if (c == Company.Microsoft) return "Microsoft";
            else if (c == Company.Craft_Ltd) return "Craft Ltd";
            else if (c == Company.MKS) return "MKS";
            else return "Nestle";
        }

        public static String OutOfDateToStr(Boolean d)
        {
            if (d == true) return "Истек";
            else return "Не истек";
        }

        public override string ToString()
        {
            String s = string.Format(
                "********************************************************\n" +
                "ID: {0}, Название товара: {1}\n" +
                "Производитель: {2}\n" +
                "Цена: {3}\n" +
                "Количество: {4} шт., Срок годности: {5}\n" +
                "********************************************************",
                ID, ProductName, CompanyToStr(CompanyName), Price, Count, OutOfDateToStr(OutOfDate));
            return s;
        }
    }
}
