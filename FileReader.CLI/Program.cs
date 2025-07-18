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

                IFileReader fileReader = FileReaderFactory.Create(fileType);

                if (fileType == FileType.Text)
                {
                    Console.WriteLine("Is this file encrypted? (y/n):");
                    var encryptedAnswer = Console.ReadLine()?.Trim().ToLower();
                    if (encryptedAnswer == "y")
                    {
                        fileReader = new EncryptedFileReader(fileReader, new ReverseEncryptionStrategy());
                    }

                    var userRole = UserRolePrompter.Prompt();
                    fileReader = new RoleBasedFileReader(
                        fileReader,
                        new SimpleRoleSecurityStrategy(),
                        userRole.ToString().ToLower()
                    );
                }

                if (fileType == FileType.Xml)
                {
                    var userRole = UserRolePrompter.Prompt();
                    fileReader = new RoleBasedFileReader(
                        fileReader,
                        new SimpleRoleSecurityStrategy(),
                        userRole.ToString().ToLower()
                    );

                    Console.WriteLine("Is this file encrypted? (y/n):");
                    var encryptedAnswer = Console.ReadLine()?.Trim().ToLower();
                    if (encryptedAnswer == "y")
                    {
                        fileReader = new EncryptedFileReader(fileReader, new ReverseEncryptionStrategy());
                    }
                }

                if (fileType == FileType.Json)
                {
                    Console.WriteLine("Is this file encrypted? (y/n):");
                    var encryptedAnswer = Console.ReadLine()?.Trim().ToLower();
                    if (encryptedAnswer == "y")
                    {
                        fileReader = new EncryptedFileReader(fileReader, new ReverseEncryptionStrategy());
                    }

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