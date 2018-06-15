using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn1 = Connection.GetConnection();
            SqlConnection conn2 = Connection.GetConnection();
        }
    }
}
