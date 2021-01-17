using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODBC_Viewer
{
    public interface IDBViewer
    {
        string ConnectionString { get; }

        string Query  { get;  }

        object Result { set; }

        string Status { set; }
    }
}
