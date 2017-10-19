using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SimplePlanning.WebElements
{
	public class Button : Element
	{
		public Button(By locator) : base(locator) { }

		public Button(IWebElement element) : base(element) { }

		public void Click()
		{
			WebElement.Click();
		}
	}
}
