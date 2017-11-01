using OpenQA.Selenium;

namespace Core.WebElements
{
	public class Button : Element
	{
		public Button(By locator) : base(locator) { }
		public void Click()
		{
			WebElement.Click();
		}
	}
}
