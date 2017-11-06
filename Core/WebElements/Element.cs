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
