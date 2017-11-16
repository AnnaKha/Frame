using Core.DriverCore;
using Core.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Core.WebElements
{
	public class Element
	{
		private IWebElement _webElement;
		public By Locator { get; protected set; }

		public bool IsEnabled => WebElement.Enabled;

		public bool IsDisplayed => WebElement.Displayed;
		public bool IsSelected => WebElement.Selected;

		public string GetValue => WebElement.GetAttribute("value");

		public void Child(By locator) => WebElement.FindElement(locator);

		public void Children(By locator) => WebElement.FindElements(locator);

		protected Element(By locator) => Locator = locator;

		protected IWebElement FindVisibleElement(By selector, TimeSpan? timeout = null) => Driver.WaitFor(selector, timeout);

		protected IWebElement WebElement
		{
			get { return _webElement ?? Driver.Instance.FindElement(Locator); }
			private set { _webElement = value; }
		}
		public void WaitForDisplayed(TimeSpan ts)
		{
			Driver.WaitFor(Locator, ts);
		}
		public void WaitForNotDisplayed(TimeSpan ts)
		{
			Driver.WaitForElementIsHidden(Locator, ts);
		}
	}
}
