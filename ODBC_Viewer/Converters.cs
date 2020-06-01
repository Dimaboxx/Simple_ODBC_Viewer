using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace ODBC_Viewer
{
    class Converters
    {
    }
     class RowNumberConverter : IValueConverter
       {
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                DataGridRow row = value as DataGridRow;
                if (row == null)
                    throw new InvalidOperationException("This converter class can only be used with DataGridRow elements.");

                return row.GetIndex() + 1;
            }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotSupportedException();
            }
        }

}
