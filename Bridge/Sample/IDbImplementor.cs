using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Sample
{
    interface IDbImplementor
    {
        void Execute(string sql);
        void OpenConnection(string sqlCon);
    }
}
