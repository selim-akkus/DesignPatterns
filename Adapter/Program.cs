using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //no adapter
            ILog log = new DatabaseLog();
            log.Logla("bababa");

            //adapter
            log = new XmlLogAdapter();
            log.Logla("bababa");

            Console.ReadKey();

        }
    }
}
