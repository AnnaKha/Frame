using System;
using System.Collections.Generic;
using System.Linq;
using Core.DriverCore;
using OpenQA.Selenium;

namespace Core.Tables
{
	public abstract class TableBase<T> where T : RowBase
	{
		protected abstract string Row { get; }

		public IList<T> Rows => Driver.Instance.FindElements(By.XPath(Row)).Select(CreateInstance<T>).ToList();

		private TRow CreateInstance<TRow>(IWebElement element) where TRow : RowBase
		{
			return Activator.CreateInstance(typeof(TRow), element) as TRow;
		}
	}
}