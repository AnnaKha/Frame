using NUnit.Framework;
using SimplePlanning.Tables;
using System.Linq;

namespace SimplePlanning.PageObjects
{
	public class RetirementCurrentSavingsModal
	{
		public CurrentSavingsTable CurrentSavings = new CurrentSavingsTable();

		public void verify()
		{
			string value = CurrentSavings.Rows.First().Accounts;
			Assert.That(CurrentSavings.Rows.First().Accounts.Equals("Charles'401k"));
		}
	}
}
