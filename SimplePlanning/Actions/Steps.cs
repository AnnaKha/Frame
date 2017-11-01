using Core.Configuration;

namespace SimplePlanning.Actions
{
	public class Steps
	{
		public OverviewSteps OverviewPageStep { get; } = new OverviewSteps();

		public void OpenApplication(string url)
		{
			Driver.GoToUrl(url);
		}

	}
}
