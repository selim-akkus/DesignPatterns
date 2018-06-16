using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Climate : CarDecorator
    {

        Car _car;

        public Climate(Car car)
        {
            this._car = car;
        }

        public override decimal Price()
        {
            return _car.Price() + 5000;
        }
    }
}
