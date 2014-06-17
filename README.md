Command Line Encoder
====================

Using this library or just the Utils.cs class you can safely encode text arguments to command line.


You can download the library from here:       
https://github.com/ericpopivker/Command-Line-Encoder/releases


Or just copy the Utils class that let's you EncodeArgText and DecodeArgText from:    
https://github.com/ericpopivker/Command-Line-Encoder/blob/master/CommandLineEncoder/CommandLineEncoder/Utils.cs


Features
--------

This CommandLineEncoder handles the following edge cases when using text arguments in command line

* line breaks
* slashes followed by quotes
* quotes
* last slash before closing quote


How to use
----------

1) Either copy Utils.cs class into your project from:   
https://github.com/ericpopivker/Command-Line-Encoder/blob/master/CommandLineEncoder/CommandLineEncoder/Utils.cs  
or reference library from latest release in here:  
https://github.com/ericpopivker/Command-Line-Encoder/releases

2) Call CommandLineEncoder.EncodeArgText("Some Value") to encode text argument to use on command line.

```
string args = String.Format("--someFlag1 --testVal \"{0}\" --someFlag2", 
    								CommandLineEncoder.Utils.EncodeArgText(argText)
    				  			);
System.Diagnostics.Process.Start(ApplicationExePath, args);
```		

3) Use  CommandLineEncoder.DecodeArgText() to decode text argument from command line

```
static void Main(string[] args)
{
	string argText = CommandLineEncoder.Utils.DecodeArgText(args[2]);
}
```


Background
----------

Once upon a time, I wrote an open source Find and Replace tool:  https://findandreplace.codeplex.com, which allows users to easily generate re-usable command line statements for finding and replacing text in files.

It worked great, except people kept filing issues related to problems with escaping backslashes, quotes and new line breaks.  In GUI - everything worked ok, but as soon as the person would try to generate a command line - it wouldn't work the same way.

After a bit of research I found an article which explains the problem:

http://weblogs.asp.net/jgalloway/archive/2006/10/05/_5B002E00_NET-Gotcha_5D00_-Commandline-args-ending-in-_5C002200_-are-subject-to-CommandLineToArgvW-whackiness.aspx
	
The gist is:   
> "Most apps (including .Net apps) use CommandLineToArgvW to decode their command lines.  It uses crazy escaping rules which explain the behaviour you're seeing."
	
CommandLineEncoder fixes the issues mentioned in the article.  It also adds line break handling.


Unit Tests
----------

There are learning tests that demonstarate the original issue:  
https://github.com/ericpopivker/Command-Line-Encoder/blob/master/CommandLineEncoder/CommandLineEncoder.Tests/LearningTests.cs

There are also unit tests that verifies librariy functionality:  
https://github.com/ericpopivker/Command-Line-Encoder/blob/master/CommandLineEncoder/CommandLineEncoder.Tests/UtilsTest.cs


In both cases - the automated tests work by instantianting a very simple command line EXE which writes the results to a temp text file, which is then read back by unit test after a short delay.





