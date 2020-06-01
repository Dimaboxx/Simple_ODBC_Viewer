using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.Odbc;

namespace ODBC_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime starttime = DateTime.UtcNow;
                 var connectionStringBuilder = new OdbcConnectionStringBuilder
                {
                    Dsn = tb_DSN.Text,
                };

                OdbcConnection con = new OdbcConnection(connectionStringBuilder.ConnectionString);
                DataTable dt = new DataTable();

                OdbcDataAdapter da = new OdbcDataAdapter();

                var sql = tb_query.Text;

                da.SelectCommand = new OdbcCommand(sql, con);
            try
            {
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                gridAllView.DataContext = dt.DefaultView;
                tx_result.DataContext = DateTime.UtcNow.Subtract(starttime).ToString(@"hh\:mm\:ss\.fffffff");
            }

        }

    }
}
