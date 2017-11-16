using Core.Configuration;
using SimplePlanning.PageObjects;
using SimplePlanning.TestData;

namespace SimplePlanning.Steps
{
	public class RetirementPlanningSteps : RetirementPlanning
	{
		private string pathToFile = Config.TestData;
		public Common _common = new Common();

		public void OpenCurrentSavingsModal()
		{
			CurrentDedicatedAccountsLink.Click();
			_common.VerifyModalTitle("Retirement");
		}
		public void OpenChartSettingsPopover()
		{
			ChartSettingsLink.Click();
			_common.VerifyPopoverTitle("Chart Settings");
		}

		public void VerifyCurrentSavingsModal()
		{
			new JsonReader("CurrentSavings", 0, pathToFile);
			string modalName = JsonReader.testCaseValues["ModalName"];
			SavingsModal.ValidateCurrentSavingsTable();
		}
	}
}
