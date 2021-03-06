﻿using OpenQA.Selenium;
using Core.WebElements;
using System.Collections.Generic;

namespace SimplePlanning.PageObjects
{
	public class OverviewPage
	{
		public ClickElement CreatePlan = new ClickElement(By.XPath("//button[text()='Create a Plan']"));

		public TextElement CurrentSituationTitle = new TextElement(By.XPath("//div[contains(@class,'current-situation')]//div[contains(@class,'section-header')]"));
		public TextElement ProposedPlanTitle = new TextElement(By.XPath("//div[contains(@class,'proposed-plan')]//div[contains(@class,'section-header')]"));
		public TextElement CurrentSituationTile = new TextElement(By.XPath("//div[@class='current-situation-tile-description']"));
		public TextElement PlanningSectionTitle = new TextElement(By.XPath("//div[@class='proposed-plan-description']/div"));
		public TextElement PlanningSectionText = new TextElement(By.XPath("//div[@class='proposed-plan-description__text']"));
		public TextElement ModulesText = new TextElement(By.XPath("//div[@class='proposed-plan-description__title']"));
		public TextElement ModulesToComplete = new TextElement(By.XPath("//ul[@class='proposed-plan-description-list']"));

		public List<string> ModulesToCompleteItems => ModulesToComplete.Items(
						By.XPath(".//span[contains(@class,'fa fa-check-circle check-icon')]//following-sibling::span"));

	}
}
