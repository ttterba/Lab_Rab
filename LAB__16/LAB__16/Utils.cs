using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB__16
{
    class Utils
    {
        private static Dictionary<int, String> dict;
        static Utils()
        {
            if (dict == null)
            {
                dict = new Dictionary<int, string>(3);
                dict.Add(0, "Количество автобусных рейсов");
                dict.Add(1, "Суммарная стоимость билетов на самолет");
                dict.Add(2, "Самый дорогой билет");
            }
        }

        public static String GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
                return dict[number];
            else
                return "???";
        }
    }
}
