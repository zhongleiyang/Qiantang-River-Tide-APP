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
    public partial class Search : PhoneApplicationPage
    {
        public Search()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);
            bindList(timePick.Value.Value.Month, timePick.Value.Value.Day);
            textBlock.Text = Data.referenceData;
        }


        private void bindList(int month, int day)
        {

            var subset = from tide in TideData.dataList where tide.month == month && tide.day == day select tide;
            List<Note> notes = new List<Note>();
            foreach (var tide in subset)
            {
                string _time = "2012年" + tide.month.ToString() + "月" + tide.day.ToString() + "日"
                    + tide.hour.ToString() + "时" + tide.minite + "分";
                string _tideHeight = "潮高： " + String.Format("{0:0.00}", 1.0 * tide.level/100) + "米";
                notes.Add(new Note(_time, _tideHeight));
            }


            //notes.Add( new Note(){ time = "2012年1月1日10时1分", tideHeight = "潮高：100米"});
            //notes.Add(new Note() { time = "2012年1月1日10时3分", tideHeight = "潮高：101米" });
            //notes.Add(new Note() { time = "2012年1月1日10时4分", tideHeight = "潮高：102米" });
            //notes.Add(new Note() { time = "2012年1月1日10时5分", tideHeight = "潮高：103米" });           
            listBox.ItemsSource = notes;
        }

        private void DatePicker_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {

            bindList(e.NewDateTime.Value.Month, e.NewDateTime.Value.Day);
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            
        }


        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    TideData.searchMonth = Convert.ToInt32(monthTextBox.Text);
        //    TideData.searchDay = Convert.ToInt32(dayTextBox.Text);
        //    NavigationService.Navigate(new Uri("/result.xaml", UriKind.Relative));
        //}
    }
}