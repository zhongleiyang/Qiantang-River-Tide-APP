using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TideSearchApp
{
    public class Tide
    {
        public Tide() { }
        public Tide(int _month, int _day, int _hour, int _minite, int _level)
        {
            month = _month;
            day = _day;
            hour = _hour;
            minite = _minite;
            level = _level;
        }
        public int month { get; set; }
        public int day { get; set; }
        public int hour { get; set; }
        public int minite { get; set; }
        public int level { get; set; }
    }

    public class Note
    {
        public Note(string _time, string _tideHeight)
        {
            time = _time;
            tideHeight = _tideHeight;

        }
        public string time { get; set; }
        public string tideHeight { get; set; }
    }


    static class TideData
    {
        public static List<Tide> dataList = new List<Tide>();
        public static List<Tide> bestTimeList = new List<Tide>();
        public static int searchMonth =0;
        public static int searchDay = 0;
        public static void initTideData()
        {
            init(Data.time, dataList);
        }



        public static void initBestTimeData()
        {
            init(Data.bestTime, bestTimeList);
        }

        private static void init(string data, List<Tide> list)
        {            
            string temp= data.Replace('\t', ' ');


            StringReader objReader = new StringReader(temp);


            string s = "";
            while ((s = objReader.ReadLine()) != null)
            {

                string[] fields = s.Split(' ');
                list.Add(new Tide(Convert.ToInt32(fields[0]), Convert.ToInt32(fields[1]),
                    Convert.ToInt32(fields[2]), Convert.ToInt32(fields[3]), Convert.ToInt32(fields[4])));
            }



        }
    }


}
