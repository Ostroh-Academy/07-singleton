using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denysiuk_Pattern_Singleton
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object padlock = new object();
        private ConfigurationData configData;

        private ConfigurationManager()
        {
            // Load configuration data from a file, database, or other sources
            configData = new ConfigurationData
            {
                DatabaseConnectionString = "server=localhost;database=mydb;uid=user;pwd=password",
                Port = 8080,
                ApiKey = "abc123def456"
            };
        }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                    return instance;
                }
            }
        }

        public ConfigurationData GetConfigData()
        {
            return configData;
        }
    }
}
