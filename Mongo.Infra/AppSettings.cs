using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo.Infra
{
    public class AppSettings
    {
        string _connectionString;
        string _DatabaseName;

        public string ConnectionString { get => _connectionString; set => _connectionString = value; }
        public string DatabaseName { get => _DatabaseName; set => _DatabaseName = value; }
    }
}
