using System.IO;

namespace CommandLineEncoder.Tests.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var outfile = new StreamWriter("Output.log"))
			{
				outfile.Write(args[2]);
			} 
		}
	}
}
