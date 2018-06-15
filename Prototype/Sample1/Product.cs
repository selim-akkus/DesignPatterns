using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Sample1
{
    class Product : IPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }
    }
}
