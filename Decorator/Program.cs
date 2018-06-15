using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Car araba = new Bmw();
            araba.Aciklama = "Bmw";
            Console.WriteLine(araba.Aciklama + " : " + araba.Price());

            Car klimaliAraba = new Climate(araba);
            Console.WriteLine(klimaliAraba.Price());

            Car klimaliAirBagliAraba = new AirBag(klimaliAraba);
            Console.WriteLine(klimaliAirBagliAraba.Price());


            Console.ReadKey();
        }
    }
}
