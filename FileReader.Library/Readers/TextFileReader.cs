using FileReader.Library.Common;

namespace FileReader.Library.Readers
{
    public class TextFileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}