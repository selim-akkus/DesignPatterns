using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton
{
    class Connection
    {
        static SqlConnection _connection;

        private Connection()
        {

        }

        static object _lock = new object();
        public static SqlConnection GetConnection()
        {
            if (_connection == null)
            {
                lock (_lock)
                {
                    if (_connection == null)
                    {
                        _connection = new SqlConnection();
                    }
                }
            }

            return _connection;
        }
    }
}
