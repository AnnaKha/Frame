using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using SimplePlanning.Helpers;
using SimplePlanning.PageObjects;


namespace SimplePlanning.Steps
{
    public class OverviewSteps
    {
        private readonly OverviewPage _overviewPage = new OverviewPage();

        public void GoToRetiremenPlanningPage()
        {
            _overviewPage.CreatePlan.Click();
            Thread.Sleep(3000);
        }

        public List<string> GetModulesToComplete
        {
            get
            {
                return
                    _overviewPage.ModulesToComplete.Items(
                        By.XPath(".//span[contains(@class,'fa fa-check-circle check-icon')]//following-sibling::span"));
            }
        }

        public string CurrentSituationHeading
        {
            get
            {
                return _overviewPage.CurrentSituationHeader.GetText;
            }
        }

        public void OpenApplication(string url)
        {
            Driver.GoToUrl(url);
        }

        public void Verify()
        {
            Assert.That(CurrentSituationHeading.Equals("Current Situation (Client Facts)"));
            Assert.AreEqual(GetModulesToComplete, new List<string> { "Goals" });

            GoToRetiremenPlanningPage();
        }
    }
}
