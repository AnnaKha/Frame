using SimplePlanning.PageObjects;

namespace SimplePlanning.Steps
{
	public class RetirementPlanningSteps : RetirementPlanning
	{
		public void OpenCurrentSavingsModal()
		{
			CurrentDedicatedAccountsLink.Click();
			SavingsModal.verify();
		}
	}
}
