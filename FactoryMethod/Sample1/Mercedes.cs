using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample1
{
    class Mercedes : ICar
    {
        public void Show()
        {
            Console.WriteLine("Mercedes");
        }
    }
}
