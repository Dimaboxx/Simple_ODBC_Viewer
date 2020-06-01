using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace png2ico
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = File.OpenWrite(@"Z:\_Education\C#\C# с нуля до PRO\Theme_17_ODBC_Viewer\ODBC_Viewer\res\test.ico"))
            {
                Bitmap bitmap = (Bitmap)Image.FromFile(@"Z:\_Education\C#\C# с нуля до PRO\Theme_17_ODBC_Viewer\ODBC_Viewer\res\odbc.png");
                Icon.FromHandle(bitmap.GetHicon()).Save(stream);
            }
        }
    }
}
