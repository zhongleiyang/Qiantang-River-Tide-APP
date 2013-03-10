﻿using System;
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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
                   
        }

        private void introduction_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/introduction.xaml", UriKind.Relative));

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Search.xaml", UriKind.Relative));
        }

        private void onterInfo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/otherInfo.xaml", UriKind.Relative));
        }

        private void bestDayLocation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/bestTimeLocation.xaml", UriKind.Relative));
        }
    }
}