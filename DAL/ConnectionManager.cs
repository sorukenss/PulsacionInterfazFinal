using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class ConnectionManager
    {
        public SqlConnection Connection;

        public ConnectionManager(string connection)
        {
            Connection = new SqlConnection(connection);
        }

        public void Open()
        {
            Connection.Open();
        }

        public void Close()
        {
            Connection.Close();
        }

        public string Estado()
        {
            return Connection.State.ToString();
        }

        public string Version()
        {
            return Connection.ServerVersion.ToString();
        }

    }
}
