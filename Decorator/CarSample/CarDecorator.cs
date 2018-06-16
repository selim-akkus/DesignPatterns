﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class CarDecorator : Car
    {

        public override abstract decimal Price();
    }
}
