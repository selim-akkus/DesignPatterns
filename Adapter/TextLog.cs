using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class TextLog : ILog
    {
        public void Logla(string str)
        {
            Console.WriteLine("Text loglandı : " + str);
        }
    }
}
