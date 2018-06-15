using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample1
{
    class Toyota : ICar
    {
        public void Show()
        {
            Console.WriteLine("Toyota");
        }
    }
}
