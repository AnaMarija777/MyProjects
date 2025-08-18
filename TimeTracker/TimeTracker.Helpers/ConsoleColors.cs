using System;
namespace TimeTracker.Helpers
{
	public class ConsoleColors
	{
		public static void PrintSuccsess(string text)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(text);
			Console.ResetColor();
		}
		public static void PrintError(string text)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(text);
			Console.ResetColor();
		}

	}

}

