namespace FileReader.Library.Security
{
    public interface IRoleSecurityStrategy
    {
        bool CanRead(string path, string role);
    }
}