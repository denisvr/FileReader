namespace FileReader.Library
{
    public class JsonFileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}