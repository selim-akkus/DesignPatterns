using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AbstractProductB_1 : AbstractProductB
    {
        public override void Run(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " > " + a.GetType().Name);
        }
    }
}
