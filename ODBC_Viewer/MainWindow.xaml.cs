﻿using System;
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


namespace ODBC_Viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDBViewer
    {

        //OdbcDataAdapter da;
        //OdbcConnection con;
        //OdbcConnectionStringBuilder connectionStringBuilder;
        //DataTable dt;

        Presenter presenter;
        
        public MainWindow()
        {
            presenter = new Presenter(this);
            InitializeComponent();
        }

        public string ConnectionString { get => tb_DSN.Text; }
        public string Query { get => tb_query.Text;  }
        public object Result { set => gridAllView.DataContext = value; }

        public string Status { set => tx_result.Text = value; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            presenter.Request();


            //DateTime starttime = DateTime.UtcNow;
            //if (connectionStringBuilder == null)
            //    connectionStringBuilder = new OdbcConnectionStringBuilder();
            //connectionStringBuilder.Dsn = tb_DSN.Text;
            //if (con == null)
            //     con = new OdbcConnection();
            //con.ConnectionString = connectionStringBuilder.ConnectionString;
            //if (dt == null)
            //    dt = new DataTable();
            //else
            //    dt.Clear();

            //if(da == null)
            //    da = new OdbcDataAdapter();

            //    var sql = tb_query.Text;

            //    da.SelectCommand = new OdbcCommand(sql, con);
            //try
            //{
            //    da.Fill(dt);
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    gridAllView.DataContext = dt.DefaultView;
            //    string ressting = $"Got {dt.Rows.Count} rows in {DateTime.UtcNow.Subtract(starttime).ToString(@"hh\:mm\:ss\.fffffff")}";
            //    tx_result.DataContext = ressting;
            //}

        }

    }
}
