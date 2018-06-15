using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    class RutbeliAskerComposit : AskerComponent
    {
        public string Ad { get; set; }

        private string rutbe;

        private List<AskerComponent> _askerList = new List<AskerComponent>();

        public string Rutbe
        {
            get { return rutbe; }
            set { rutbe = value; }
        }

        public override void Add(AskerComponent asker)
        {
            _askerList.Add(asker);
        }

        public override void Emret()
        {
            Console.WriteLine(Ad + " : " + rutbe);

            foreach (var item in _askerList)
            {
                item.Emret();
            }
        }

        public override void Remove(AskerComponent asker)
        {
            _askerList.Remove(asker);
        }
    }
}
