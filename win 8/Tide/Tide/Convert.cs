using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace Tide
{

    public class MonthConverter : IValueConverter
    { 
        //数据转换的方法   
        public object Convert(object value, Type targetType, object parameter, string culture)  
        {       
             return value.ToString() + "月";
           
        }   
        //双向绑定时，Convert方法的反向实现   
        public object ConvertBack(object value, Type targetType, object parameter, string culture)   
        {      
            return null; 
        }
    }

    public class DayConverter : IValueConverter
    {
        //数据转换的方法   
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return value.ToString() + "日";

        }
        //双向绑定时，Convert方法的反向实现   
        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }

    public class MiniteConverter : IValueConverter
    {
        //数据转换的方法   
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return value.ToString() + "分";

        }
        //双向绑定时，Convert方法的反向实现   
        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }

    public class HourConverter : IValueConverter
    {
        //数据转换的方法   
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return value.ToString() + "时";

        }
        //双向绑定时，Convert方法的反向实现   
        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }

    public class LevelConverter : IValueConverter
    {
        //数据转换的方法   
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            return (1.0 * (int)value / 100).ToString() + "米";

        }
        //双向绑定时，Convert方法的反向实现   
        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }


}
