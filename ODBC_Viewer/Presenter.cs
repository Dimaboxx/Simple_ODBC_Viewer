using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows;
using System.Diagnostics;

namespace ODBC_Viewer
{
    public class Presenter
    {
        IDBViewer view;

        OdbcDataAdapter da;
        OdbcConnection con;
        OdbcConnectionStringBuilder connectionStringBuilder;
        DataTable dt;

        public Presenter(IDBViewer viewer)
        {
            view = viewer;    
        }

        public void Request ()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            if (connectionStringBuilder == null)
                connectionStringBuilder = new OdbcConnectionStringBuilder();
            connectionStringBuilder.Dsn = view.ConnectionString;
            if (con == null)
            if (con == null)
            if (con == null)
            if (con == null)
                con = new OdbcConnection();
            con.ConnectionString = connectionStringBuilder.ConnectionString;
            if (dt == null)
                dt = new DataTable();
            else
                dt.Clear();

            if (da == null)
                da = new OdbcDataAdapter();

            var sql = view.Query;

            da.SelectCommand = new OdbcCommand(sql, con);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stopwatch.Stop();
                view.Result = dt.DefaultView;
                string ressting = $"Got {dt.Rows.Count} rows in {stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fffffff")}";
                view.Status = ressting;
            }

        }

    }
}
