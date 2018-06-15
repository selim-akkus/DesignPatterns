using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sample1
{
    public class CarFactory
    {
        public ICar CreateCar(string marka)
        {
            if (marka == "Toyota")
                return new Toyota();
            else if (marka == "Citroen")
                return new Citroen();
            else if (marka == "Mercedes")
                return new Mercedes();
            else
                return null;
        }
    }
}
