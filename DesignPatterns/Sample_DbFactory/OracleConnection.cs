using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class OracleConnection : Connection
    {
        public override void Open()
        {
            Console.WriteLine("OracleConnection açıldı.");
        }
    }
}
