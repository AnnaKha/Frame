using Core.WebElements;
using OpenQA.Selenium;

namespace SimplePlanning.PageObjects
{
	public class RetirementPlanning : Common
	{
		public RetirementCurrentSavingsModal SavingsModal = new RetirementCurrentSavingsModal();
		public ChartSettingsPopover ChartSettingsPopover = new ChartSettingsPopover();
		public ClickElement CurrentDedicatedAccountsLink = new ClickElement(By.XPath("//div[@class='current-situation-section']//button[contains(@class, 'savings__link')]"));
		public ClickElement ChartSettingsLink = new ClickElement(By.XPath("//button[text()='Chart Settings']"));
	}
}
