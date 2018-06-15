using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DbFactory
    {
        Connection _connection;
        DbCommand _command;

        public DbFactory(DatabaseFactory _factory)
        {
            _connection = _factory.GetConnection();
            _command = _factory.GetCommand();
        }

        public void Start()
        {
            _command.Execute(_connection, "select * from ..");
        }
    }
}
