using System.IO;
using NUnit.Framework;

namespace SimplePlanning.TestData
{
	public class JsonReader
	{
		public string ReadFromFile(string pathToFile)
		{
		    var workingDerictory = TestContext.CurrentContext.TestDirectory;

		    return File.ReadAllText(Path.Combine(workingDerictory, pathToFile));
		}
	}
}