using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object lockObject = new object();
        public string ConfigValue { get; private set; }

        // Private constructor to prevent instantiation
        private ConfigurationManager()
        {
            ConfigValue = "Default Configuration";
        }

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }
            }
            return instance;
        }

        public void SetConfig(string value)
        {
            ConfigValue = value;
        }

        public void ShowConfig()
        {
            Console.WriteLine("Configuration: " + ConfigValue);
        }
    }

}
