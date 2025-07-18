using FileReader.Library;

namespace FileReader.CLI
{
    public static class FileTypePrompter
    {
        public static FileType Prompt()
        {
            while (true)
            {
                Console.WriteLine("Select file type:");
                Console.WriteLine("1) Text");
                Console.WriteLine("2) XML");

                var input = Console.ReadLine()?.Trim();

                if (input == "1")
                    return FileType.Text;
                if (input == "2")
                    return FileType.Xml;

                Console.WriteLine("Invalid selection. Please enter the number of the file type.");
            }
        }
    }
}