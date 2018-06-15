using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composit
{
    class Program
    {
        static void Main(string[] args)
        {
            RutbeliAskerComposit general = new RutbeliAskerComposit();
            general.Ad = "Selim";
            general.Rutbe = "General";

            RutbeliAskerComposit albay = new RutbeliAskerComposit()
            {
                Ad = "Zeynep",
                Rutbe = "Albay"
            };

            general.Add(albay);

            RutbesizAskerComposit asker = new RutbesizAskerComposit() { Ad = "Elif" };

            albay.Add(asker);

            general.Emret();

            Console.ReadKey();
        }
    }
}
