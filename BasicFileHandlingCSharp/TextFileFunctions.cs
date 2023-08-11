namespace BasicFileHandlingCSharp
{
	public class TextFileFunctions
	{
		private readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory;

		string _fileName = "FileNameExample.txt";

		public TextFileFunctions( string fileName ) { _fileName = fileName; }

		public void WriteFile( string[] lines )
		{
			using StreamWriter writer = new StreamWriter(Path.Combine(_rootPath, _fileName), true);
			foreach (string line in lines)
			{
				writer.WriteLine(line);
			}

		}

		public string ReadFile()
		{
			using StreamReader reader = new StreamReader(Path.Combine(_rootPath, _fileName), true);
			return reader.ReadToEnd();
		}
	}
}
