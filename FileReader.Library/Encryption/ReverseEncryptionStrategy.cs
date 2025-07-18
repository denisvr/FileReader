namespace FileReader.Library.Encryption
{
    public class ReverseEncryptionStrategy : IEncryptionStrategy
    {
        public string Decrypt(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}