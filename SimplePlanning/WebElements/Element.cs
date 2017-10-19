using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SimplePlanning.Helpers;

namespace SimplePlanning.WebElements
{
	public class Element
	{
		public By Locator { get; protected set; }

		private IWebElement _webElement;

		protected IWebElement WebElement
		{
			get { return _webElement ?? Driver.Instance.FindElement(Locator); }
			private set { _webElement = value; }
		}

		protected T CreateInstance<T>(IWebElement element) where T : Element
		{
			return Activator.CreateInstance(typeof(T), element) as T;
		}

		protected T CreateInstance<T>(By locator) where T : Element
		{
			return Activator.CreateInstance(typeof(T), locator) as T;
		}

		protected Element(By locator)
		{
			Locator = locator;
		}

		protected Element(IWebElement element)
		{
			WebElement = element;
		}
	}
}
