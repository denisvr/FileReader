namespace FileReader.Library
{
    public class EncryptedFileReader : IFileReader
    {
        private readonly IFileReader _innerReader;
        private readonly IEncryptionStrategy _encryption;

        public EncryptedFileReader(IFileReader innerReader, IEncryptionStrategy encryption)
        {
            _innerReader = innerReader;
            _encryption = encryption;
        }

        public string Read(string path)
        {
            var encryptedContent = _innerReader.Read(path);
            return _encryption.Decrypt(encryptedContent);
        }
    }
}