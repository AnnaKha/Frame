using Core.DriverCore;
using Core.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Core.WebElements
{
	public class Input : Element
	{
		public Input(By locator) : base(locator) { }

		private const string InputGroupElement = ".//ancestor::div[@class='input-group']";
		public void SetJavaScriptText(string text)
		{
			WaitForDisplayed(Timeouts.Default);
			((IJavaScriptExecutor)Driver.Instance).ExecuteScript("arguments[0].value = arguments[1]", WebElement, text);
			Actions action = new Actions(Driver.Instance);
			action.MoveByOffset(155, 155).Click().Build().Perform();
			Assert.That(GetValue.Equals(text));
			Logger.LoggingHelper.LogInformation("Increase/Decrease step is correct");
		}

		public void SetText(string text)
		{
			WaitForDisplayed(Timeouts.Default);
			WebElement.SendKeys(Keys.Control + "a");
			WebElement.SendKeys(Keys.Delete);
			WebElement.SendKeys(text);
			Actions action = new Actions(Driver.Instance);
			action.MoveByOffset(155, 155).Click().Build().Perform();
			Assert.That(GetValue.Equals(text));
		}

		public void RemoveText(string text)
		{
			WaitForDisplayed(Timeouts.Default);
			WebElement.SendKeys(Keys.Control + "a");
			WebElement.SendKeys(Keys.Delete);
			Actions action = new Actions(Driver.Instance);
			action.MoveByOffset(155, 155).Click().Build().Perform();
			Assert.IsEmpty(GetValue);
		}

		public bool HasError()
		{
			WaitForDisplayed(Timeouts.Default);
			string error = WebElement.GetAttribute("aria-invalid");
			return error.Equals("false");
		}

		public string GetValidationMessage()
		{
			WaitForDisplayed(Timeouts.Default);
			return WebElement.FindElement(By.XPath($"{InputGroupElement}/following-sibling::div[contains(@id, 'helpblock')]//span[contains(@class,'input-helptext-error')]")).Text;
		}

		public string GetInputLabel()
		{
			WaitForDisplayed(Timeouts.Default);
			return WebElement.FindElement(By.XPath($"{InputGroupElement}/preceding-sibling::label/span/span")).Text;
		}

		public string  HasLeadingSign()
		{
			try
			{
				WaitForDisplayed(Timeouts.Default);
				string sign = WebElement.FindElement(By.XPath($"{InputGroupElement}//span[@class='input-group-addon']")).Text;
				return sign;
			}
			catch (NoSuchElementException)
			{
				return string.Empty;
			}
		}

		public string HasFollowingSign()
		{
			try
			{
				WaitForDisplayed(Timeouts.Default);
				string sign = WebElement.FindElement(By.XPath("./following-sibling::span[@class='input-group-addon']")).Text;
				return sign;
			}
			catch (NoSuchElementException)
			{
				return string.Empty;
			}
		}
	}
}
