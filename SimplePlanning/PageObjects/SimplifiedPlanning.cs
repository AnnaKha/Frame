using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using SimplePlanning.Steps;

namespace SimplePlanning.PageObjects
{
	public static class SimplifiedPlanning
	{
		private static Overview _overview;
		public static Overview Overview
		{
			get { return _overview ?? (_overview = new Overview()); }
		}
	}
}
