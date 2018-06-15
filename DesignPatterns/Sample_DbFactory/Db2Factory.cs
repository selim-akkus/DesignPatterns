using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Db2Factory : DatabaseFactory
    {
        public override DbCommand GetCommand()
        {
            return new Db2Command();
        }

        public override Connection GetConnection()
        {
            return new Db2Connection();
        }
    }
}
