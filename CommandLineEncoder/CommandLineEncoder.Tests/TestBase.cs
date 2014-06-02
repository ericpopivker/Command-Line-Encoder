using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineEncoder.Tests
{
	public class TestBase
	{
		protected static string ApplicationExePath = @"CommandLineEncoder.Tests.Console.exe";


		protected static string GetValueFromOutput()
		{
			string result = String.Empty;

			var filename = "Output.log";

			if (File.Exists(filename))
			{
				using (var outfile = new StreamReader(filename))
				{
					result = outfile.ReadToEnd();
				}
			}

			return result;
		}

		protected static string GenCommandLine(string value)
		{
			return String.Format("--someFlag1 --testVal \"{0}\" --someFlag2", value);
		}
	}
}
