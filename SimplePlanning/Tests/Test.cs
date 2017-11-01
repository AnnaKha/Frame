using NUnit.Framework;
using Core.Configuration;
using SimplePlanning.Actions;

namespace SimplePlanning.Tests
{
	[TestFixture]
	public class Test : TestSetUp
	{
		private readonly Steps Steps = new Steps();
		private static readonly string Url = Config.Url;

		[Test]
		public void OverviewPage()
		{
			Steps.OpenApplication(Url);
			Steps.OverviewPageStep.VerifyCurrentSituationSection();
			Steps.OverviewPageStep.VerifyProposedPlanSection();
			Steps.OverviewPageStep.GoToRetiremenPlanningPage();
		}
	}
}