using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SimplePlanning.WebElements
{
	public class TextElement : Element
	{
		public TextElement(By locator) : base(locator) { }

		public TextElement(IWebElement element) : base(element) { }

		public string GetText => WebElement.Text.Replace("\r\n", " ");

		public List<string> Items(By locator)
		{
			return WebElement.FindElements(locator).Select(i=>i.Text).ToList();
		}
	}
}
