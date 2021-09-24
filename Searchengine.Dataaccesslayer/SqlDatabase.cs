using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searchengine.Dataaccesslayer
{
    public class SqlDatabase
    {
        //we will implement the database connection in this with help of ADO.NET and also keep the methods static

        public static SqlConnection GetConnection()
        {
            SqlConnection sqlConn = new SqlConnection("Connection String");

            return sqlConn;
        }
    }
}
