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
    public partial class dangerInfo : PhoneApplicationPage
    {
        public dangerInfo()
        {
            InitializeComponent();
            this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentUICulture.Name);

            textBlock.Text = Data.dangerData;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
          
        }
    }
}