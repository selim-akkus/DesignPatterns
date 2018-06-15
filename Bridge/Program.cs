using Bridge.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            DbAbstraction abstraction = new DbRefinedAbstratction(new SqlServerImplementor());
            abstraction.Connection("sdasd");
            abstraction.Execute("select * from ..");

            Console.ReadKey();
        }
    }
}
