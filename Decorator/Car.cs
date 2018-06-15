using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class Car
    {
        private string _model;

        public string Aciklama
        {
            get { return _model; }
            set { _model = value; }
        }
        public abstract decimal Price();
    }
}
