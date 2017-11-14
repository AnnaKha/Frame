using OpenQA.Selenium;

namespace Core.WebElements
{
	public class ClickElement : Element
	{
		public ClickElement(By locator) : base(locator) { }
		public void Click()
		{
			WebElement.Click();
		}
	}
}
