using System;
using System.Configuration;


namespace SimplePlanning.Helpers
{
    public class Configuration
    {
        public static string Driver => GetRequiredString("driver");
        public static string Url => GetRequiredString("Url");

        private static string GetRequiredString(string name)
        {
            string value = ConfigurationManager.AppSettings[name];
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(
                        string.Format("Configuration parameter " +name+ " was not found"));
            }
            return value;
        }

    }
}
