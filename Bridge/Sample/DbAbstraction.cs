using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    abstract class DbAbstraction
    {
        protected IDbImplementor _implementor;

        public DbAbstraction(IDbImplementor implementor)
        {
            _implementor = implementor;
        }

        public IDbImplementor Implementor
        {
            set { Implementor = value; }
        }

        public abstract void Connection(string str);

        public abstract void Execute(string str);
    }
}
