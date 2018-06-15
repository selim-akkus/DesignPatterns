using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreateBuillder2 : Builder
    {
        private Product _p = new Product();
        public override void BuildPartA()
        {
            _p.Name = "Opel";
        }

        public override void BuildPartB()
        {
            _p.Category = "Otomobil";
        }

        public override Product GetResult()
        {
            return _p;
        }
    }
}
