
using Core.Tables;

namespace SimplePlanning.Tables
{
	public class CurrentSavingsTable: TableBase<CurrentSavingsRow>
	{
		protected override string Row => "//table[@class='table']//caption[text()='Current Savings']/following-sibling::tbody//td/..";
	}
}
