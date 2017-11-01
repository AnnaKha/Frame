using NUnit.Framework;
using Core.Configuration;

namespace SimplePlanning.Tests
{
	public class TestSetUp
	{
		[SetUp]
		public void SetUp()
		{
			Driver.Initialize();
		}

		[TearDown]
		public void CleanUp()
		{
			Driver.QuitBrowser();
		}
	}
}
