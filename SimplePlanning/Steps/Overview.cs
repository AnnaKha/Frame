using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SimplePlanning.PageObjects;


namespace SimplePlanning.Steps
{
	public class Overview : OverviewPage
	{
		public  void GoToRetiremenPlanningPage()
		{
			CreatePlan.Click();
			Thread.Sleep(3000);
		}

		public List<string> GetModulesToComplete
		{
			get
			{
				return
					ModulesToComplete.Items(
						By.XPath(".//span[contains(@class,'fa fa-check-circle check-icon')]//following-sibling::span"));
			}
		}

		public string CurrentSituationHeading
		{
			get
			{
				return CurrentSituationHeader.GetText;
			}
		}
		}
	}
