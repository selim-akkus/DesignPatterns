﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class DatabaseFactory
    {
        public abstract Connection GetConnection();
        public abstract DbCommand GetCommand();
    }
}
