using NUnit.Framework;
using Core.Configuration;
using SimplePlanning.Steps;

namespace SimplePlanning.Tests
{
	[TestFixture]
	public class Test : TestSetUp
	{
		private readonly Step Steps = new Step();
		private static readonly string Url = Config.Url;

		[Test]
		public void OverviewPage()
		{
			Steps.OpenApplication(Url);
			Steps.OverviewPageStep.VerifyCurrentSituationSection();
			Steps.OverviewPageStep.VerifyProposedPlanSection();
		}

		[Test]
		public void CurrentSavingsModalOnRetirementPlanningPage()
		{
			Steps.OpenApplication(Url);
			Steps.OverviewPageStep.GoToRetiremenPlanningPage();
			Steps.RetirementPlanningStep.OpenCurrentSavingsModal();
			Steps.RetirementPlanningStep.VerifyCurrentSavingsModal();
			Steps.RetirementPlanningStep.ClickDoneOnModal();
			Steps.RetirementPlanningStep.OpenCurrentSavingsModal();
			Steps.RetirementPlanningStep.ClickCloseModal();
		}

		[Test]
		public void ChartSettingPopoverOnRetirementPlanningPage()
		{
			Steps.OpenApplication(Url);
			Steps.OverviewPageStep.GoToRetiremenPlanningPage();
			Steps.RetirementPlanningStep.OpenChartSettingsPopover();
			Steps.RetirementPlanningStep.ChartSettingsPopover.VerifyPlanScoreSettingSelected();

			Steps.RetirementPlanningStep.ChartSettingsPopover.SelectGoalFundingSetting();
			Steps.RetirementPlanningStep.ChartSettingsPopover.ClickCancelOnPopover();
			Steps.RetirementPlanningStep.OpenChartSettingsPopover();
			Steps.RetirementPlanningStep.ChartSettingsPopover.VerifyPlanScoreSettingSelected();

			Steps.RetirementPlanningStep.ChartSettingsPopover.SelectGoalFundingSetting();
			Steps.RetirementPlanningStep.ChartSettingsPopover.ClickClosePopover();
			Steps.RetirementPlanningStep.OpenChartSettingsPopover();
			Steps.RetirementPlanningStep.ChartSettingsPopover.VerifyPlanScoreSettingSelected();

			Steps.RetirementPlanningStep.ChartSettingsPopover.SelectGoalFundingSetting();
			Steps.RetirementPlanningStep.ClickSaveOnPopover();
			Steps.RetirementPlanningStep.OpenChartSettingsPopover();
			Steps.RetirementPlanningStep.ChartSettingsPopover.VerifyGoalFundingSelected();

			Steps.RetirementPlanningStep.ChartSettingsPopover.SelectPlanScoreSetting();
			Steps.RetirementPlanningStep.ClickSaveOnPopover();
			Steps.RetirementPlanningStep.OpenChartSettingsPopover();
			Steps.RetirementPlanningStep.ChartSettingsPopover.VerifyPlanScoreSettingSelected();
		}
	}
}