using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Markup;
using System.Threading;
namespace TideSearchApp
{
    public partial class PivotPage2 : PhoneApplicationPage
    {



        private void bindList()
        {


            List<Note> notes = new List<Note>();
            foreach (var tide in TideData.bestTimeList)
            {
                string _time = "2012年" + tide.month.ToString() + "月" + tide.day.ToString() + "日"
                    + tide.hour.ToString() + "时" + tide.minite + "分";
                string _tideHeight = "潮高： " + String.Format("{0:0.00}", 1.0 * tide.level / 100) + "米";
                notes.Add(new Note(_time, _tideHeight));
            }

           
            listBox.ItemsSource = notes;
        }

        public PivotPage2()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);
            bindList();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}