using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreJWTAuthentication.Database
{
    public class DatabaseSettings : IDBSettings
    {
        public string CollectionName { get ; set ; } = "Default CollectionName";
        public string ConnectionString { get ; set ; } = "Default ConnectionString";
        public string DatabaseName { get ; set ; } = "Default DatabaseName";
    }
}