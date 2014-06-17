Command Line Encoder
====================

#### Encode and decode text arguments for use on command line.


Using this library or just the Utils class you can safely encode text arguments to command line.


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




Background
----------

Once upon a time, I wrote an open source Find and Replace tool:  https://findandreplace.codeplex.com, which allows users to easily generate re-usable command line statements for finding and replacing text in files.

It worked great, except people kept filing issues related to problems with escaping backslashes, quotes and new line breaks.  In GUI - everything worked ok, but as soon as the person would try to generate a command line - it wouldn't work the same way.

After a bit of research I found an article which explains the problem:
http://weblogs.asp.net/jgalloway/archive/2006/10/05/_5B002E00_NET-Gotcha_5D00_-Commandline-args-ending-in-_5C002200_-are-subject-to-CommandLineToArgvW-whackiness.aspx
	
	
	



