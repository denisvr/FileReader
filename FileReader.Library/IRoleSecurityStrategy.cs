namespace FileReader.Library
{
    public interface IRoleSecurityStrategy
    {
        bool CanRead(string path, string role);
    }
}