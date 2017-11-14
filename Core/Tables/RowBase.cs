using System.Linq;
using OpenQA.Selenium;

namespace Core.Tables
{
	public class RowBase
	{
		private readonly IWebElement _element;

		protected RowBase(IWebElement element)
		{
			_element = element;
		}
		protected string GetTdText(int cellIndex)
		{
			var elements = _element.FindElements(By.XPath(".//td"));
			if (!elements.Any()) return null;
			var element = elements.ElementAt(cellIndex);
			//element.ScrollTo();

			return element.Text;
		}
	}
}
