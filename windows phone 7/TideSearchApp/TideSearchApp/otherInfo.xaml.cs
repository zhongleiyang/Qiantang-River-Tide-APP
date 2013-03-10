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
    public partial class 其他信息 : PhoneApplicationPage
    {
        public 其他信息()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);
        }


        private void imageButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ImagePage.xaml", UriKind.Relative));
        }

        private void trafficButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TrafficInfo.xaml", UriKind.Relative));
        }

        private void NearInfoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/nearInfo.xaml", UriKind.Relative));
        }

        private void dangerInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/dangerInfo.xaml", UriKind.Relative));
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
        }
    }
}