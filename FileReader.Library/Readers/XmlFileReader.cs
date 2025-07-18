using FileReader.Library.Common;

namespace FileReader.Library.Readers
{
    public class XmlFileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}