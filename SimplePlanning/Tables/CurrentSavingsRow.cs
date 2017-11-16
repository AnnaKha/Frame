using Core.Tables;
using OpenQA.Selenium;

namespace SimplePlanning.Tables
{
	public class CurrentSavingsRow : RowBase
	{
		public CurrentSavingsRow(IWebElement element) : base(element) { }
		public string Accounts => GetTdText(0);
		public string Total => GetTdText(1);
	}
}
