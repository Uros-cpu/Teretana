using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Teretana.DataLayer
{
    public static class ConnectionHelper
    {
        private static readonly string connectionString =
            @"Data Source=(localdb)\ProjectModels;Initial Catalog=TeretanaDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
