using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class ConcreateProduct2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new AbsractProductA_2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new AbstractProductB_2();
        }
    }
}
