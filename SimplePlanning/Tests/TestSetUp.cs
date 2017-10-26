using NUnit.Framework;
using SimplePlanning.Helpers;

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
