using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    class SqlServerImplementor : IDbImplementor
    {
        public void Execute(string sql)
        {
            Console.WriteLine(this.GetType().Name + " Sorgu çalıştırıldı.");
        }

        public void OpenConnection(string strSqlConn)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = strSqlConn;
            //conn.Open();

            Console.WriteLine(this.GetType().Name + " Connection açıldı.");
        }
    }
}
