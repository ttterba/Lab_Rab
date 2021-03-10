using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace LAB__16
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }

        private List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '*';
        public DataStorage() { }

        private void BuildSummary()
        {
            Dictionary<int, float> tmp = new Dictionary<int, float>();
            foreach (var item in rawdata)
            {
                int group = -1;
                if (item.TransportType == "Автобус") group = 0;
                if (item.TransportType == "Самолет") group = 1;

                if (group == 1)
                {
                    if (tmp.ContainsKey(group))
                        tmp[group] += item.Price;
                    else
                        tmp[group] = item.Price;
                }
                else if (group == 0)
                {
                    if (tmp.ContainsKey(group))
                        tmp[group]++;
                    else
                        tmp[group] = 1;
                }

                if (tmp.ContainsKey(2))
                {
                    if (item.Price > tmp[2])
                        tmp[2] = item.Price;
                } else
                    tmp[2] = item.Price;

            }

            sumdata = new List<SummaryDataItem>();
            foreach (var item in tmp)
            {
                sumdata.Add(new SummaryDataItem()
                {
                    GroupName = Utils.GetGroupByNumber(item.Key),
                    GroupSum = item.Value
                });
            }
        }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();

            try
            {
                StreamReader sr = new StreamReader(datapath);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        TransportType = items[0].Trim(),
                        From = items[1].Trim(),
                        To = items[2].Trim(),
                        Price = Convert.ToSingle(items[3].Trim(), CultureInfo.InvariantCulture),
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            } catch (IOException ex)
            {
                return false;
            }
            return true;
        }

        public static DataStorage DataCreator(String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else
                return null;
        }

        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}
