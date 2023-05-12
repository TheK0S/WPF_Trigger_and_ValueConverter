using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp2
{
    class PositionForecolorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string)
            {
                string str = value.ToString();

                if(str != null)
                {
                    if (str.ToLower().Contains("директор"))
                        return "директор";
                    else if (str.ToLower().Contains("менеджер"))
                        return "менеджер";
                    else
                        return value;
                }                
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
