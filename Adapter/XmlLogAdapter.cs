using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class XmlLogAdapter : ILog
    {
        public void Logla(string str)
        {
            XmlLog log = new XmlLog();
            log.LogAt(str);
        }
    }
}
