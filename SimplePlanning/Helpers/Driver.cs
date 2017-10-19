using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SimplePlanning.Helpers
{
	public class Driver
	{
		private static IWebDriver _instance;

		public static IWebDriver Instance
		{
			get
			{
				if (_instance == null)
				{
					Initialize();
				}
				return _instance;
			}
		}

		private static void Initialize()
		{
			string browser = Configuration.Driver;

			if (String.Equals(browser, "Chrome", StringComparison.CurrentCultureIgnoreCase))
			{
				_instance = new ChromeDriver();
			}
			else if (String.Equals(browser, "Firefox", StringComparison.CurrentCultureIgnoreCase))
			{
				_instance = new FirefoxDriver();
			}
			else if (String.Equals(browser, "InternetExplorer", StringComparison.CurrentCultureIgnoreCase))
			{
				_instance = new InternetExplorerDriver();
			}
			else
				throw new Exception("unknown driver: " + browser);
		}

		public static void GoToUrl(string url)
		{
			Instance.Navigate().GoToUrl(url);
			Instance.Manage().Window.Maximize();
		}

		public static void CloseBrowser()
		{
			if (_instance != null)
			{
				Instance.Close();
			}
			_instance = null;
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
