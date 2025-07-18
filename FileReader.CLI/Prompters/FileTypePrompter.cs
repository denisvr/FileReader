using FileReader.Library.Common;

namespace FileReader.CLI.Prompters
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
                Console.WriteLine("3) JSON");
                var input = Console.ReadLine()?.Trim();
                switch (input)
                {
                    case "1":
                        return FileType.Text;

                    case "2":
                        return FileType.Xml;

                    case "3":
                        return FileType.Json;

                    default:
                        Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}