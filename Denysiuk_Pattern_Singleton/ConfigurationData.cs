using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denysiuk_Pattern_Singleton
{
    public class ConfigurationData
    {
        public string DatabaseConnectionString { get; set; }
        public int Port { get; set; }
        public string ApiKey { get; set; }

        // Other properties for configuration data...
    }
}
