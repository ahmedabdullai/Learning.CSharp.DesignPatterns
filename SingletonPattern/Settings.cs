using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    internal class Settings
    {
        private static Settings? instance;

        public static Settings GetInstance()
        {
            instance ??= new Settings();
            return instance;
        }

        private Dictionary<string, string> configs = [];

        public void SetConfig(string key, string value)
        {
            configs[key] = value;
        }

        public string GetConfig(string key) {
            return configs[key];
        }

        public void PrintConfigs()
        {
            foreach (var config in configs)
            {
                Console.WriteLine($"{config.Key}: {config.Value}");
            }
        }
    }
}
