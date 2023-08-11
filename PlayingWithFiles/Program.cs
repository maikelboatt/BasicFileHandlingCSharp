using BasicFileHandlingCSharp;

namespace PlayingWithFiles
{
	public class Program
	{
		static void Main( string[] args )
		{
			int count = 0;

			try
			{
				WriteHeadingToScreen();

				Console.WriteLine("Please enter a name for your file");

				string fileName = Console.ReadLine();

				Console.WriteLine();

				string[] lines = new string[3];

				TextFileFunctions textFileFunctions = new(fileName);

				do
				{
					Console.WriteLine($"Please add {(count > 0 ? "another line" : "a line")} to file, {fileName}");
					lines[count] = Console.ReadLine();
					count++;

				} while (count < 3);
				textFileFunctions.WriteFile(lines);

				Console.Clear();

				WriteHeadingToScreen();

				Console.WriteLine(textFileFunctions.ReadFile());


			}
			catch (IOException ex)
			{
				WriteExceptionToScreen(ex);
			}
		}

		private static void WriteHeadingToScreen()
		{
			Console.WriteLine("Basic .NET Cross Platform File Handling");
			Console.WriteLine("_______________________________________");
			Console.WriteLine();
		}

		private static void WriteExceptionToScreen( IOException ex )
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(ex.Message);
			Console.ResetColor();
		}
	}
}