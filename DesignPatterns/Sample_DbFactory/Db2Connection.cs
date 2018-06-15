using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Db2Connection : Connection
    {
        public override void Open()
        {
            Console.WriteLine("Db2Connection açıldı");
        }
    }
}
