using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PizzaShop
{
    class BolMalzemePizzaBuilder : PizzaBuilder
    {
        Pizza pizza = new Pizza();
        public override void BuildFiyat()
        {
            pizza.Fiyat = 18;
        }

        public override void BuildHamur()
        {
            pizza.Hamur = "Kalın";
        }

        public override void BuildMalzeme()
        {
            pizza.MalzemeEkle("Zeytin");
            pizza.MalzemeEkle("Sucuk");
            pizza.MalzemeEkle("Salam");
            pizza.MalzemeEkle("Peynir");
        }

        public override void BuildSos()
        {
            pizza.Sos = "Pepperoni";
        }

        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}
