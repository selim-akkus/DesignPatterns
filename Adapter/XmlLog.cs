using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class XmlLog
    {
        public void LogAt(string str)
        {
            Console.WriteLine("XML log : " + str);
        }
    }
}
