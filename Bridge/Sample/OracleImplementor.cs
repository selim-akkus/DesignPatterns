using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    class OracleImplementor : IDbImplementor
    {
        public void Execute(string sql)
        {
            Console.WriteLine(this.GetType().Name + " Sorgu çalıştırıldı.");
        }

        public void OpenConnection(string strSqlConn)
        {
            Console.WriteLine(this.GetType().Name + " Connection açıldı.");
        }
    }
}
