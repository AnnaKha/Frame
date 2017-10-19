using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SimplePlanning.WebElements;

namespace SimplePlanning.PageObjects
{
	public class OverviewPage
	{
		public Button CreatePlan = new Button(By.XPath("//button[text()='Create a Plan']"));

		public TextElement CurrentSituationHeader = new TextElement(By.XPath("//div[contains(@class,'current-situation')]//div[contains(@class,'section-header')]"));
		public TextElement ProposedPlanHeader = new TextElement(By.XPath("//div[contains(@class,'proposed-plan')]//div[contains(@class,'section-header')]"));
		public TextElement PlanningSectionText = new TextElement(By.XPath("//div[@class='proposed-plan-description']//div"));
		//public TextElement PlanningSectionText = new TextElement(By.XPath("//div[@class='proposed-plan-description__text']"));
		//public TextElement PlanningSectionTitle= new TextElement(By.XPath("//div[@class='proposed-plan-description__title']"));
		public TextElement ModulesToComplete = new TextElement(By.XPath("//ul[@class='proposed-plan-description-list']"));

	}
}
