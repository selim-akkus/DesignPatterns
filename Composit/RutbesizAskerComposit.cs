using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    class RutbesizAskerComposit : AskerComponent
    {
        private string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public override void Add(AskerComponent asker)
        {
            throw new NotImplementedException();
        }

        public override void Emret()
        {
            Console.Write(_ad);
        }

        public override void Remove(AskerComponent asker)
        {
            throw new NotImplementedException();
        }
    }
}
