using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using SimplePlanning.PageObjects;
using SimplePlanning.TestData;
using Core.Configuration;

namespace SimplePlanning.Steps
{
	public class OverviewSteps
	{
		public Common _common = new Common();
		private readonly OverviewPage _overviewPage = new OverviewPage();
		private string pathToFile = Config.TestData;

		public void GoToRetiremenPlanningPage()
		{
			_overviewPage.CreatePlan.Click();
			Thread.Sleep(2000);
			_common.VerifyPageWithBackLinkHeader("Planning");
		}

		public void VerifyCurrentSituationSection()
		{
			new JsonReader("OverviewPage", 0, pathToFile);
			string currentSituationHeader = JsonReader.testCaseValues["CurrentSituationTitle"];
			string goalTile = JsonReader.testCaseValues["GoalTile"];

			Assert.That(_overviewPage.CurrentSituationTitle.GetText.Equals(currentSituationHeader));
			Assert.That(_overviewPage.CurrentSituationTile.GetText.Equals(goalTile));
		}
		public void VerifyProposedPlanSection()
		{
			new JsonReader("OverviewPage", 0, pathToFile);
			string proposedPlanTitle = JsonReader.testCaseValues["ProposedPlanTitle"];
			string itemsToComplete = JsonReader.testCaseValues["ItemsToComplete"];
			string planningTitle = JsonReader.testCaseValues["PlanningTitle"];
			string planningText = JsonReader.testCaseValues["PlanningText"];
			string modulesText = JsonReader.testCaseValues["ModulesText"];

			Assert.That(_overviewPage.ProposedPlanTitle.GetText.Equals(proposedPlanTitle));
			Assert.That(_overviewPage.PlanningSectionTitle.GetText.Equals(planningTitle));
			Assert.That(_overviewPage.PlanningSectionText.GetText.Equals(planningText));
			Assert.That(_overviewPage.ModulesText.GetText.Equals(modulesText));
			Assert.AreEqual(_overviewPage.ModulesToCompleteItems, new List<string> { itemsToComplete });
		}
	}
}