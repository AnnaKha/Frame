using System;
using System.Configuration;

namespace Core.Configuration
{
    public static class Config
    {
        public static string BrowserName => GetRequiredString("BrowserName");
        public static string Url => GetRequiredString("Url");

        private static string GetRequiredString(string name)
        {
            var value = ConfigurationManager.AppSettings[name];

            if (string.IsNullOrEmpty(value))
            {
                throw new Exception($"Configuration parameter {name} was not found");
            }

            return value;
        }
    }
}
