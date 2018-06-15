using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AbstractProductA_1 : AbstractProductA
    {
        public override void Run(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + " > " + b.GetType().Name);
        }
    }
}
