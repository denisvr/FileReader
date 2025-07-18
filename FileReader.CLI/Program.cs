using FileReader.Library;

namespace FileReader.CLI
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                var fileType = FileTypePrompter.Prompt();
                var path = FilePathPrompter.Prompt(fileType);

                try
                {
                    var fileReader = FileReaderFactory.Create(fileType);
                    var content = fileReader.Read(path);
                    Console.WriteLine($"\n--- {fileType.ToString().ToUpper()} File Content ---\n{content}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError reading file: {ex.Message}");
                }

                Console.WriteLine("\nWould you like to read another file? (y/n):");
                var answer = Console.ReadLine()?.Trim().ToLower();
                if (answer != "y")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}