using FileReader.CLI.Prompters;
using FileReader.Library.Common;
using FileReader.Library.Encryption;
using FileReader.Library.Factory;
using FileReader.Library.Security;

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

                IFileReader fileReader = FileReaderFactory.Create(fileType);

                Console.WriteLine("Is this file encrypted? (y/n):");

                var encryptedAnswer = Console.ReadLine()?.Trim().ToLower();

                if (encryptedAnswer == "y")
                {
                    fileReader = new EncryptedFileReader(fileReader, new ReverseEncryptionStrategy());
                }

                Console.WriteLine("Do you want to use role-based security? (y/n):");

                var roleSecurityAnswer = Console.ReadLine()?.Trim().ToLower();

                if (roleSecurityAnswer == "y")
                {
                    var userRole = UserRolePrompter.Prompt();
                    fileReader = new RoleBasedFileReader(
                        fileReader,
                        new SimpleRoleSecurityStrategy(),
                        userRole.ToString().ToLower()
                    );
                }

                try
                {
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