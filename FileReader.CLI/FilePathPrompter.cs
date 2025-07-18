using FileReader.Library;

namespace FileReader.CLI
{
    public static class FilePathPrompter
    {
        public static string Prompt(FileType fileType)
        {
            string typeName = fileType.ToString().ToLower();
            while (true)
            {
                Console.WriteLine($"Enter path to {typeName} file:");
                var path = Console.ReadLine()?.Trim(' ', '\"');
                if (string.IsNullOrWhiteSpace(path))
                {
                    Console.WriteLine("File path cannot be empty. Please try again.");
                    continue;
                }
                if (!File.Exists(path))
                {
                    Console.WriteLine("File does not exist. Please check the path and try again.");
                    continue;
                }
                return path;
            }
        }
    }
}