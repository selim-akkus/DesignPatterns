using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class OracleFactory : DatabaseFactory
    {
        public override DbCommand GetCommand()
        {
            return new OracleCommand();
        }

        public override Connection GetConnection()
        {
            return new OracleConnection();
        }
    }
}
