using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBak.Convert
{
    [System.Windows.Data.ValueConversion(typeof(int), typeof(string))]
    public class ConvertIntToString : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string visi = "";
            if (bool.Parse(value.ToString()) == false)
            {
                visi = "Collapsed";
            }
            else
            {
                visi = "Visible";
            }
            return visi;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ConvertIntToString2 : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string visi = "";
            if (bool.Parse(value.ToString()) == false)
            {
                visi = "Visible";
            }
            else
            {
                visi = "Collapsed";
            }
            return visi;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
