using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tide
{
    public class LeastDateItem
    {
        public LeastDateItem(int _hour, int _minite, int _level)
        {
            hour = _hour;
            minite = _minite;
            level = _level;
        }

        public int hour { get; set; }
        public int minite { get; set; }
        public int level { get; set; }
    }


    public class TideDateItem
    {
        public TideDateItem( int _day)
        {
            day = _day;
        }

        public int day { get; set; }
        public List<LeastDateItem> Items = new List<LeastDateItem>();

    }

    public class TideData
    {
        public TideData(string i)
        {
            month = i;
        }
        public string month { get; set; }
        public List<TideDateItem> Items = new List<TideDateItem>();


    }

    public class TideDataSource
    {
        public  ObservableCollection<TideData> TideDatas = new ObservableCollection<TideData>();

        public TideDataSource()
        {
            string temp = Data.time.Replace("\t", " ");
            StringReader objReader = new StringReader(temp);

            string s = "";
           

            for (int i = 1; i < 13; i++)
            {
                TideData tideData = new TideData(i.ToString());
                TideDatas.Add(tideData);         
            }

            


            while ((s = objReader.ReadLine()) != null)
            {

                string[] fields = s.Split(' ');

                TideData tideDate = TideDatas[Convert.ToInt32(fields[0]) - 1];

                TideDateItem tideDateItem = find(tideDate.Items, Convert.ToInt32(fields[1]));

                if(tideDateItem == null)
                {
                    tideDateItem = new TideDateItem(Convert.ToInt32(fields[1]));
                     TideDatas[Convert.ToInt32(fields[0]) - 1].Items.Add(tideDateItem);
                }

                tideDateItem.Items.Add(new LeastDateItem(Convert.ToInt32(fields[2]), Convert.ToInt32(fields[3]), Convert.ToInt32(fields[4])));
            }
        }

        TideDateItem find(List<TideDateItem> Items, int day)
        {
            foreach (TideDateItem tideDataItem in Items)
            {
                if (tideDataItem.day == day)
                    return tideDataItem;
            }

            return null;
        }


    }


}
