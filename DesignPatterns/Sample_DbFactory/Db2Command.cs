using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Db2Command : DbCommand
    {
        public override void Execute(Connection conn, string sql)
        {
            conn.Open();
            Console.WriteLine("Db2Command çalıştı.");
        }
    }
}
