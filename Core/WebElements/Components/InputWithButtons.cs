using Core.DriverCore;
using Core.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.WebElements;
using NUnit.Framework;

namespace Core.WebElements
{
	public class InputWithButtons : Input
	{
		public InputWithButtons(By locator) : base(locator) { }

		public void ClickIncrease()
		{
			WebElement.FindElement(By.XPath(".//ancestor::div[@class='input-group']//div[@class='input-group-btn']//button[@aria-label='increase value']"))
				.Click();
		}

		public void ClickDecrease()
		{
			WebElement.FindElement(By.XPath(".//ancestor::div[@class='input-group']//div[@class='input-group-btn']//button[@aria-label='decrease value']"))
				.Click();
		}
	}
}
