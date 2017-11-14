using Core.WebElements;
using OpenQA.Selenium;

namespace SimplePlanning.PageObjects
{
	public class RetirementPlanning
	{
		public RetirementCurrentSavingsModal SavingsModal = new RetirementCurrentSavingsModal();
		public ClickElement CurrentDedicatedAccountsLink = new ClickElement(By.XPath("//div[@class='current-situation-section']//button[contains(@class, 'savings__link')]"));
	}
}
