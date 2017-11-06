using NUnit.Framework;
using Core.DriverCore;

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
