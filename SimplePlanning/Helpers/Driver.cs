using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SimplePlanning.Helpers
{
    public enum Browsers
    {
        Chrome,
        Firefox,
        IE
    }

	public static class Driver
	{
        private static IWebDriver _instance;

		public static IWebDriver Instance
		{
			get
			{
			    return _instance ?? Initialize();
			}
		}

		public static IWebDriver Initialize()
		{
			var browser = Configuration.BrowserName;

            var browserName = (Browsers)Enum.Parse(typeof(Browsers), browser);

            switch (browserName)
		    {
                case Browsers.Chrome:
                    return _instance = new ChromeDriver();
                case Browsers.Firefox:
                    return _instance = new FirefoxDriver();
                case Browsers.IE:
                    return _instance = new InternetExplorerDriver();
                default:
                    throw new Exception("Unknown driver: " + browser);
            }
		}

		public static void GoToUrl(string url)
		{
			Instance.Navigate().GoToUrl(url);
			Instance.Manage().Window.Maximize();
		}

		public static void QuitBrowser()
		{
			if (_instance != null)
			{
				Instance.Quit();
			}

			_instance = null;
		}
	}
}
