using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SimplePlanning.PageObjects;
using SimplePlanning.Steps;

namespace SimplePlanning.Tests
{
	[TestFixture]

	public class Test : TestSetUp
	{
		[Test]
		public void OverviewPage()
		{
			Assert.That(SimplifiedPlanning.Overview.CurrentSituationHeading.Equals("Current Situation (Client Facts)"));
			Assert.AreEqual(SimplifiedPlanning.Overview.GetModulesToComplete, new List<string> { "Goals"});
			SimplifiedPlanning.Overview.GoToRetiremenPlanningPage();
		}

		[Test]
		public void GoalsPage()
		{

		}
	}
}