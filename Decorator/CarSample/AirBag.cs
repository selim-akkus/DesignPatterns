using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AirBag : CarDecorator
    {
        Car _car;

        public AirBag(Car car)
        {
            this._car = car;
        }

        public override decimal Price()
        {
            return _car.Price() + 3000;
        }
    }
}
