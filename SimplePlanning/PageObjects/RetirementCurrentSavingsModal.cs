using Core.Configuration;
using NUnit.Framework;
using SimplePlanning.Tables;
using SimplePlanning.TestData;
using System.Linq;

namespace SimplePlanning.PageObjects
{
	public class RetirementCurrentSavingsModal : Common
	{
		private string pathToFile = Config.TestData;
		public CurrentSavingsTable CurrentSavings = new CurrentSavingsTable();

		public void ValidateCurrentSavingsTable()
		{
			new JsonReader("CurrentSavings", 0, pathToFile);
			string columns = JsonReader.testCaseValues["Columns"];
			string savingsName1 = JsonReader.testCaseValues["SavingsName1"];
			string savingsName2 = JsonReader.testCaseValues["SavingsName2"];
			string totalName = JsonReader.testCaseValues["TotalName"];
			string savingsValue1 = JsonReader.testCaseValues["SavingsValue1"];
			string savingsValue2 = JsonReader.testCaseValues["SavingsValue2"];
			string savingsValue3 = JsonReader.testCaseValues["SavingsValue3"];
			string totalValue = JsonReader.testCaseValues["TotalValue"];

			GetTableColumns.SequenceEqual(columns.Split(',').ToList());
			Assert.That(CurrentSavings.Rows.First().Accounts.Equals(savingsName1));
			Assert.That(CurrentSavings.Rows[1].Accounts.Equals(savingsName2));
			Assert.That(CurrentSavings.Rows[2].Accounts.Equals(savingsName2));
			Assert.That(CurrentSavings.Rows[3].Accounts.Equals(totalName));
			Assert.That(CurrentSavings.Rows.First().Total.Equals(savingsValue1));
			Assert.That(CurrentSavings.Rows[1].Total.Equals(savingsValue2));
			Assert.That(CurrentSavings.Rows[2].Total.Equals(savingsValue3));
			Assert.That(CurrentSavings.Rows[3].Total.Equals(totalValue));
		}
	}
}
