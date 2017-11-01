using Core.WebElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SimplePlanning.PageObjects
{
	public class Common
	{
		public TextElement PageHeader = new TextElement(By.XPath("//h1[contains(@class,'page-header')]"));
		public TextElement PageHeaderWithBackLink = new TextElement(By.XPath("//h1[contains(@class,'page-header')]//span[not(@class)]"));

		public void VerifyPageHeader(string expectedHeader)
		{
			Assert.That(PageHeader.GetText.Equals(expectedHeader));
		}
		public void VerifyPageWithBackLinkHeader(string expectedHeader)
		{
			Assert.That(PageHeaderWithBackLink.GetText.Equals(expectedHeader));
		}
	}
}
