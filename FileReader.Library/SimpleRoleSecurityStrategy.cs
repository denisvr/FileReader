using System.IO;

namespace FileReader.Library
{
    public class SimpleRoleSecurityStrategy : IRoleSecurityStrategy
    {
        public bool CanRead(string path, string role)
        {
            return CanRead(path, Enum.TryParse<UserRole>(role, true, out var userRole) ? userRole : UserRole.User);
        }

        public static bool CanRead(string path, UserRole userRole)
        {
            if (userRole == UserRole.Admin) return true;
            if (userRole == UserRole.User && Path.GetFileName(path).StartsWith("public_")) return true;
            return false;
        }
    }
}
