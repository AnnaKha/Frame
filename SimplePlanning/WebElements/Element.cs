using OpenQA.Selenium;
using SimplePlanning.Helpers;

namespace SimplePlanning.WebElements
{
	public class Element
	{
	    private IWebElement _webElement;
        public By Locator { get; protected set; }
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
