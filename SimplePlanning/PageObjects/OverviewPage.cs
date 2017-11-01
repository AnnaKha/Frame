using OpenQA.Selenium;
using Core.WebElements;
using System.Collections.Generic;

namespace SimplePlanning.PageObjects
{
	public class OverviewPage
	{
		public Button CreatePlan = new Button(By.XPath("//button[text()='Create a Plan']"));

		public TextElement CurrentSituationTitle = new TextElement(By.XPath("//div[contains(@class,'current-situation')]//div[contains(@class,'section-header')]"));
		public TextElement ProposedPlanTitle = new TextElement(By.XPath("//div[contains(@class,'proposed-plan')]//div[contains(@class,'section-header')]"));
		public TextElement CurrentSituationTile = new TextElement(By.XPath("//div[@class='current-situation-tile-description']"));
		public TextElement PlanningSectionText = new TextElement(By.XPath("//div[@class='proposed-plan-description']//div"));
		public TextElement ModulesToComplete = new TextElement(By.XPath("//ul[@class='proposed-plan-description-list']"));

		public List<string> ModulesToCompleteItems
		{
			get
			{
				return
					ModulesToComplete.Items(
						By.XPath(".//span[contains(@class,'fa fa-check-circle check-icon')]//following-sibling::span"));
			}
		}


	}
}
