using Core.Helpers;
using Core.WebElements;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SimplePlanning.PageObjects
{
	public class ChartSettingsPopover : Common
	{
		public ClickElement PlanScoreSetting = new ClickElement(By.XPath("//div[@class='popover-content']//legend[text()='View']/..//input[@value='plan-score']/following-sibling::label"));
		public ClickElement GoalFundingSetting = new ClickElement(By.XPath("//div[@class='popover-content']//legend[text()='View']/..//input[@value='goal-funding']/following-sibling::label"));
		public TextElement SelectedView = new TextElement(By.XPath(".//div[@role='radiogroup']//legend[text()='View']/..//div[contains(@class,'ctrl-radio-is-checked')]"));
		string planScore = "Plan Score";
		string goalFunding = "Available Goal Funding";
		public void SelectPlanScoreSetting()
		{
			PlanScoreSetting.Click();
			Assert.That(SelectedView.GetText.Equals(planScore));
		}
		public void VerifyPlanScoreSettingSelected()
		{
			Assert.That(SelectedView.GetText.Equals(planScore));
		}

		public void SelectGoalFundingSetting()
		{
			GoalFundingSetting.Click();
			Assert.That(SelectedView.GetText.Equals(goalFunding));
		}
		public void VerifyGoalFundingSelected()
		{
			Assert.That(SelectedView.GetText.Equals(goalFunding));
		}
	}
}
