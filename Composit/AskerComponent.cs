using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    abstract class AskerComponent
    {
        public abstract void Add(AskerComponent asker);
        public abstract void Remove(AskerComponent asker);
        public abstract void Emret();
    }
}
