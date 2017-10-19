using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SimplePlanning.TestData
{
	public class JsonReader
	{
		public void LoadJson()
		{
			using (StreamReader r = new StreamReader("TestData.json"))
			{
				string json = r.ReadToEnd();
				List<TestDataInfo> items = JsonConvert.DeserializeObject<List<TestDataInfo>>(json);
			}
		}
	}
}


