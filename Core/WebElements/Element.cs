using Core.DriverCore;
using OpenQA.Selenium;

namespace Core.WebElements
{
	public class Element
	{
		private IWebElement _webElement;
		public By Locator { get; protected set; }

		public bool IsEnabled => WebElement.Enabled;

		public bool IsDisplayed => WebElement.Displayed;

		public string GetValue => WebElement.GetAttribute("value");

		public void Child(By locator) => WebElement.FindElement(locator);

		public void Children(By locator) => WebElement.FindElements(locator);

		protected Element(By locator)
		{
			Locator = locator;
		}

		protected IWebElement WebElement
		{
			get { return _webElement ?? Driver.Instance.FindElement(Locator); }
			private set { _webElement = value; }
		}
	}
}
