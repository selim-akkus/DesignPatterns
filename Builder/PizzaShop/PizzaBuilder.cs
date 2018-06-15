using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PizzaShop
{
    public abstract class PizzaBuilder
    {
        public abstract void BuildSos();
        public abstract void BuildHamur();
        public abstract void BuildFiyat();
        public abstract void BuildMalzeme();

        public abstract Pizza GetPizza();
    }
}
