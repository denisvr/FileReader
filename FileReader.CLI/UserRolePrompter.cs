using FileReader.Library;

namespace FileReader.CLI
{
    public static class UserRolePrompter
    {
        public static UserRole Prompt()
        {
            var roles = Enum.GetValues(typeof(UserRole));
            while (true)
            {
                Console.WriteLine("Select your role:");
                int i = 1;
                foreach (UserRole role in roles)
                {
                    Console.WriteLine($"{i}) {role}");
                    i++;
                }
                var input = Console.ReadLine()?.Trim();
                if (int.TryParse(input, out int idx) && idx >= 1 && idx <= roles.Length)
                {
                    return (UserRole)roles.GetValue(idx - 1)!;
                }
                Console.WriteLine("Invalid role. Please select a valid option.");
            }
        }
    }
}
