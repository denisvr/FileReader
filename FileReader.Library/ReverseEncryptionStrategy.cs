namespace FileReader.Library
{
    public class ReverseEncryptionStrategy : IEncryptionStrategy
    {
        public string Decrypt(string input)
        {
            return new string(input.Reverse().ToArray());
        }
    }
}