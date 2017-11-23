using Core.DriverCore;

namespace SimplePlanning.Steps
{
	public class Step
	{
		public OverviewSteps OverviewPageStep { get; } = new OverviewSteps();
		public RetirementPlanningSteps RetirementPlanningStep { get; } = new RetirementPlanningSteps();
		public void OpenApplication(string url)
		{
			Driver.GoToUrl(url);
		}
	}
}
