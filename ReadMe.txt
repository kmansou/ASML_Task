This folder contains 
	- 2 directories
		1. Source --> which contains source code for task
		2. Bin --> which contains last built binaries for Release|Any CPU
	- 2 files
		1. Re-Build.bat --> batch file to execute re-build solution without opening visual studio
		2. Run.bat --> batch file runs executable Runner.executable
		
How to Run
	- Please call "Run.bat" from any cmd window and if binaries are existed it will re-build solution after a confirmation
	
How to Build
	- Please call "Re-Build.bat" from any cmd window 

Sorce contains 6 Projects
1. Runner --> executable contains UI main form for the task
2. SumOfMultiple.Core --> library contains concrete implementation for SumOfMultiple problem (Interface and Exceptions)
3. SumOfMultiple --> library contains the real implementation for SumOfMultiple problem
4. SequenceAnalysis.Core --> library contains concrete implementation for SequenceAnalysis (upper case words analysis) problem (Interface and Exceptions)
5. SequenceAnalysis --> library contains the real implementation for for SequenceAnalysis (upper case words analysis) problem
6. ASML_Task.UnitTests --> library contains unit testing for both SumOfMultiple and SequenceAnalysis problems

Comments: 
	- ASML_Task.sln is configured to build "Release|Any CPU" by default
	- ASML_Task.sln is compatible with VS 2010, VS 2013 and VS 2015 without any need for migration
	- All Projects are compatible with .NET Framework 3.5
	- I know the task is basic to add "*.Core" libraries but I tried to show you how I code in real world
	- For real life scenario, I would Implement logging system but for simplicity I'm just reflecting the error to th UI

SumOfMultiple Problem:
	Notes:
		I implemented the most generic algorithm for this problem, then calling the method with (num1 = 3, num2 = 5 and limit = given limit)
	
	Assumptions:
		1. limit value is not included in getting sum of Multiples of 3 and 5
		2. input value for (limit) Range: 4 - 2147483647
		3. for zero value or negative given number for limit: error will be shown
		4. I used decimal type (not long or double) to keep the number unrounded for large input values of limit
		
	Analysis:
		- Time Complextiy: O(1)
		- Space Complextiy: O(1)
		- Used number theory to acheive this performance
	
	Exceptions:
		- GivenNumberIsZeroOrNegativeException: 
			* this exception is being thrown when one of the two given numbers passed to the generic method is negative or zero
			* this is not used on our case as we are always calling the generic method with 3 and 5 values
		- LimitIsLessThanNumberException
			* this exception is being thrown when limit is less than or equal the small number (in our case less than or equal 3)
		- LimitIsNegativeOrZeroException
			* his exception is being thrown when limit value is zero or negative

SequenceAnalysis Problem:
	Assumptions:
		1. English words may contain special characters like ([exclamation mark], [and], [single qoute as apostrophe], [coma], [dash], [dot], [forward slash])
		   I did analyzed english words (466'544 words) from https://github.com/dwyl/english-words/blob/master/words.txt
		2. SequenceAnalysis for upper case words may also work on latin letters like [micro], [omega] with no issue
		3. given statement must have a value and if it is null or empty it will show an error
		4. I didn't use Regular expressions to enhance performance and also I didn't use linq to provide my own implementation
		5. Result is always excluding digits and special characters from showings
		6. given string without any upper case word is not an error but returning empty result
		
	Analysis:
		- Time Complextiy: O(n)
		- Space Complextiy: O(1)
		where n is the length of given statement to be analyzed
		- I used Count sort to acheive this performance as number of characters never exceeds 256 character
	
	Exceptions:
		- GivenStringIsEmpty: 
			* this exception is being thrown when give statement string is null or empty
			
Runner Executable:
	- Program.cs is the one who is handling all exceptions through: 
		Application.ThreadException += Application_ThreadException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
	  and handlers are setting Error Text to main form, to reflect to the UI, this is for simplicity and for real life scenario, I would implement logging
	
	- Main form is showing only custom excetions, but for system exceptions Form will show "System Exception, There is no Logging System. Please contact karim.mansour91@gmail.com to check" :)
	
Thanks in advance I hope you are going to enjoy my code :)