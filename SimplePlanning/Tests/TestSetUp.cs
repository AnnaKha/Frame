using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Remote;
using SimplePlanning;
using SimplePlanning.Helpers;

namespace SimplePlanning.Tests
{
	public class TestSetUp
	{
		[SetUp]
		public void SetUp()
		{
			string url = Configuration.Url;
			Driver.GoToUrl(url);
		}

		[TearDown]
		public void CleanUp()
		{
			Driver.QuitBrowser();
		}
	}
}
