namespace FileReader.Library
{
    public class XmlFileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}