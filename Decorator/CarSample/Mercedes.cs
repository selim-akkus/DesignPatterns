using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Mercedes : Car
    {
        public override decimal Price()
        {
            return 220000;
        }
    }
}
