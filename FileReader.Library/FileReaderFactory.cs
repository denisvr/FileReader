namespace FileReader.Library
{
    public static class FileReaderFactory
    {
        public static IFileReader Create(FileType type)
        {
            return type switch
            {
                FileType.Text => new TextFileReader(),
                FileType.Xml => new XmlFileReader(),
                FileType.Json => new JsonFileReader(),
                _ => throw new NotSupportedException("Unknown file type")
            };
        }
    }
}