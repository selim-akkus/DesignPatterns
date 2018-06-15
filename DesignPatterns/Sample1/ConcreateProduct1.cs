using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ConcreateProduct1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new AbstractProductA_1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new AbstractProductB_1();
        }
    }
}
