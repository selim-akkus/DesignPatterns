using Builder.PizzaShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            //Director director = new Director();

            //Builder otobusBuilder = new ConCreateBuilder1();
            //director.Construct(otobusBuilder);
            //Product otobus = otobusBuilder.GetResult();
            //otobus.Show();

            //Builder otomobilBuilder = new ConcreateBuillder2();
            //director.Construct(otomobilBuilder);
            //Product otomobil = otomobilBuilder.GetResult();
            //otomobil.Show();

            PizzaDirector pizzaDirector = new PizzaShop.PizzaDirector();

            PizzaBuilder bolMalzemos = new BolMalzemePizzaBuilder();
            pizzaDirector.BuildPizza(bolMalzemos);
            Pizza pizza = bolMalzemos.GetPizza();
            pizza.Show();

            Console.WriteLine("*********************************");

            PizzaBuilder vejeteryanPizzaBuilder = new VejeteryanPizzaBuilder();
            pizzaDirector.BuildPizza(vejeteryanPizzaBuilder);
            pizza = vejeteryanPizzaBuilder.GetPizza();
            pizza.Show();

            Console.ReadKey();
        }
    }
}
