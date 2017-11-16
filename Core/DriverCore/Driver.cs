using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using Core.Configuration;
using OpenQA.Selenium.Support.UI;
using Core.Helpers;
using System.Linq;

namespace Core.DriverCore
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
			var browser = Config.BrowserName;

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

		public static IWebElement WaitFor(By locator, TimeSpan? timeout = null)
		{
			var wait = timeout.HasValue ? new WebDriverWait(_instance, timeout.Value) :
				new WebDriverWait(_instance, Timeouts.Default);

			return wait.Until(ExpectedConditions.ElementIsVisible(locator));
		}

		public static void WaitForElementIsHidden(By locator, TimeSpan? timeout = null)
		{
			var wait = timeout.HasValue ? new WebDriverWait(_instance, timeout.Value) :
				new WebDriverWait(_instance, Timeouts.Default);

			wait.Until(driver =>
			{
				var elements = driver.FindElements(locator);

				try
				{
					return elements.Count == 0 || elements.All(x => !x.Displayed);
				}
				// Once element is deleted from DOM webdriver throws StaleElementReferenceException
				catch (StaleElementReferenceException)
				{
					return driver.FindElements(locator).Any();
				}
			});
		}

		public static IWebElement WaitForElementPresent(By locator, TimeSpan? timeout = null)
		{
			var wait = timeout.HasValue ? new WebDriverWait(_instance, timeout.Value) :
				new WebDriverWait(_instance, Timeouts.Default);

			return wait.Until(ExpectedConditions.ElementExists(locator));
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
