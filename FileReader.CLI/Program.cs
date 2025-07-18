using FileReader.Library;
using System;
using System.IO;

internal class Program
{
    private static void Main()
    {
        while (true)
        {
            string? path = null;
            while (true)
            {
                Console.WriteLine("Enter path to text file:");
                path = Console.ReadLine()?.Trim(' ', '\"');

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

                break;
            }

            try
            {
                var reader = new TextFileReader();
                var content = reader.Read(path);
                Console.WriteLine("\n--- File Content ---\n");
                Console.WriteLine(content);
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
