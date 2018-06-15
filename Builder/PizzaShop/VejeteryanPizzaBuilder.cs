using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PizzaShop
{
    class VejeteryanPizzaBuilder : PizzaBuilder
    {
        Pizza pizza = new Pizza();
        public override void BuildFiyat()
        {
            pizza.Fiyat = 15;
        }

        public override void BuildHamur()
        {
            pizza.Hamur = "İnce";
        }

        public override void BuildMalzeme()
        {
            pizza.MalzemeEkle("Biber");
            pizza.MalzemeEkle("Zeytin");
            pizza.MalzemeEkle("Biber");
        }

        public override void BuildSos()
        {
            pizza.Sos = "Sos Yok";
        }

        public override Pizza GetPizza()
        {
            return pizza;
        }
    }
}
