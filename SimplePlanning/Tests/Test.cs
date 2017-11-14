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
			Steps.OverviewPageStep.GoToRetiremenPlanningPage();
			Steps.RetirementPlanningStep.OpenCurrentSavingsModal();
		}
	}
}