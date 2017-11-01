using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Core.WebElements
{
	public class TextElement : Element
	{
		public TextElement(By locator) : base(locator) { }
		public string GetText => WebElement.Text.Replace("\r\n", " ");

		public List<string> Items(By locator)
		{
			return WebElement.FindElements(locator).Select(i=>i.Text).ToList();
		}
	}
}
