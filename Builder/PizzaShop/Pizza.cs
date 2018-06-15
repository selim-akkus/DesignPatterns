using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.PizzaShop
{
    public class Pizza
    {
        private List<string> _malzeme = new List<string>();

        private string _sos;

        private string _hamur;

        private decimal _fiyat;

        public void MalzemeEkle(string malzeme)
        {
            _malzeme.Add(malzeme);
        }

        public string Hamur
        {
            set { this._hamur = value; }
            get { return this._hamur; }
        }

        public string Sos
        {
            get { return this._sos; }
            set { _sos = value; }
        }

        public decimal Fiyat
        {
            set { this._fiyat = value; }
            get { return this._fiyat; }
        }

        public void Show()
        {
            Console.WriteLine("Sos : " + this._sos);
            Console.WriteLine("Hamur : " + this._hamur);
            Console.WriteLine("Fiyat : " + this._fiyat);

            Console.WriteLine("Malzemeler : ");

            foreach (string item in this._malzeme)
            {
                Console.WriteLine(item);
            }
        }
    }
}
