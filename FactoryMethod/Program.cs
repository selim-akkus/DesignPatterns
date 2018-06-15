using FactoryMethod.Sample1;
using FactoryMethod.Sample2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample 1
            //CarFactory carFactory = new CarFactory();

            //ICar car = carFactory.CreateCar("Mercedes");
            //car.Show();

            //car = carFactory.CreateCar("Toyota");
            //car.Show();

            Document document = new Resume();

            foreach (Page item in document.Pages)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.WriteLine("----------------------");

            document = new Report();

            foreach (Page item in document.Pages)
            {
                Console.WriteLine(item.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
