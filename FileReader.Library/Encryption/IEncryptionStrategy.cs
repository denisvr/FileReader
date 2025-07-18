namespace FileReader.Library.Encryption
{
    public interface IEncryptionStrategy
    {
        string Decrypt(string input);
    }
}