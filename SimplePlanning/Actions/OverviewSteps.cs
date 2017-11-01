﻿using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using SimplePlanning.PageObjects;
using SimplePlanning.TestData;

namespace SimplePlanning.Actions
{
	public class OverviewSteps
	{
		public Common _common = new Common();
		private readonly OverviewPage _overviewPage = new OverviewPage();
		private const string pathToFile = @"TestData\TestData.json";
		private const string TestFile = "TestData.json";

		public void GoToRetiremenPlanningPage()
		{
			_overviewPage.CreatePlan.Click();
			Thread.Sleep(3000);
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
			//string planningText = JsonReader.testCaseValues["PlanningText"];

			Assert.That(_overviewPage.ProposedPlanTitle.GetText.Equals(proposedPlanTitle));
			//Assert.That(_overviewPage.PlanningSectionText.GetText.Equals(planningText));
			Assert.AreEqual(_overviewPage.ModulesToCompleteItems, new List<string> { itemsToComplete });
	}
	}
}