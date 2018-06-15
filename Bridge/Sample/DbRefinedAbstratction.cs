using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    class DbRefinedAbstratction : DbAbstraction
    {
        public DbRefinedAbstratction(IDbImplementor imp): base(imp)
        {
        }
        public override void Connection(string str)
        {
            _implementor.OpenConnection(str);
        }

        public override void Execute(string str)
        {
            _implementor.Execute(str);
        }
    }
}
