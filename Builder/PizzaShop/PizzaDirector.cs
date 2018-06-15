using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PizzaShop
{
    public class PizzaDirector
    {
        public void BuildPizza(PizzaBuilder builder)
        {
            builder.BuildFiyat();
            builder.BuildHamur();
            builder.BuildMalzeme();
            builder.BuildSos();
        }
    }
}
