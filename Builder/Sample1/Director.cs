using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        public void Construct(Builder _b)
        {
            _b.BuildPartA();
            _b.BuildPartB();
        }
    }
}
