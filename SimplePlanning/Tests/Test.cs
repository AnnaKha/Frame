using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;
using SimplePlanning.Helpers;
using SimplePlanning.Steps;
using SimplePlanning.TestData;
using JsonReader = SimplePlanning.TestData.JsonReader;

namespace SimplePlanning.Tests
{
	[TestFixture]
	public class Test : TestSetUp
	{
        private readonly OverviewSteps _overviewSteps = new OverviewSteps();
	    private static readonly string Url = Configuration.Url;

	    [Test]
		public void OverviewPage()
		{
            _overviewSteps.OpenApplication(Url);

            _overviewSteps.Verify();

            var jsonHelper = new JsonReader();
            var jsonData = JsonConvert.DeserializeObject<List<TestDataInfo>>(jsonHelper.ReadFromFile(@"TestData\TestData.json"));

            foreach (var dataInfo in jsonData)
            {
                var data = dataInfo;
            }
		}
	}
}