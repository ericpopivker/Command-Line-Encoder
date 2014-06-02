using System.Threading;
using NUnit.Framework;

namespace CommandLineEncoder.Tests
{
	[TestFixture]
	public class UtilsTest : TestBase
	{
		
		[Test]
		public void Encode_Decode_When_one_backslash_Then_returns_same()
		{
			TestEncodeDecode(@"\");
		}

		[Test]
		public void Encode_Decode_When_two_backslashes_Then_return_same()
		{
			TestEncodeDecode(@"\\");
		}


		[Test]
		public void Encode_Decode_When_tree_backslashes_Then_return_same()
		{
			TestEncodeDecode(@"\\\");
		}


		[Test]
		public void Encode_Decode_When_backslash_followed_by_quote_Then_returns_same()
		{
			TestEncodeDecode("\\\"");

		}


		[Test]
		public void Encode_Decode_When_two_backslashes_followed_by_quote_Then_returns_same()
		{
			TestEncodeDecode(@"\\""");
		}


		[Test]
		public void Encode_Decode_When_backslash_followed_by_quote_several_times_Then_returns_same()
		{
			TestEncodeDecode(@"\"" hello \\""  ""\");
		}


		[Test]
		public void Encode_Decode_When_value_has_line_break_Then_returns_same()
		{
			TestEncodeDecode("line1\r\nline2");
		}


		[Test]
		public void Encode_Decode_When_using_slash_n_and_line_break_Then_returns_same()
		{
			TestEncodeDecode("\\n line1\r\n    line2");
		}


		public void TestEncodeDecode(string text)
		{
			string encodedText = Utils.EncodeArgText(text);

			var cmdText = GenCommandLine(encodedText);

			System.Diagnostics.Process.Start(ApplicationExePath, cmdText);

			Thread.Sleep(1000);

			var value = GetValueFromOutput();
			var decodedValue = Utils.DecodeArgText(value);

			Assert.AreEqual(text, decodedValue);
		}
	}
}
