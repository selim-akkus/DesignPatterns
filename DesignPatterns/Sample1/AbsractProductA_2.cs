using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AbsractProductA_2 : AbstractProductA
    {
        public override void Run(AbstractProductB b)
        {
            Console.WriteLine(this.GetType().Name + " > " + b.GetType().Name);
        }
    }
}
