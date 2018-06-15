using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class DatabaseLog : ILog
    {
        public void Logla(string str)
        {
            Console.WriteLine("Database loglandı : " + str);
        }
    }
}
