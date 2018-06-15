using Prototype.Sample1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Car";

            Console.WriteLine("P1 : " + p1.Id + " - " + p1.Name);

            Product p2 = p1;
            p2.Name = "TV";

            Console.WriteLine("P2 : " + p2.Id + " - " + p2.Name);

            Product p3 = p1.Clone() as Product;
            p3.Id = 2;
            p3.Name = "Clima";

            Console.WriteLine("P3 : " + p3.Id + " - " + p3.Name);


            Console.ReadKey();
        }
    }
}
