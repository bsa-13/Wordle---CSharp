using System.IO;

namespace WordleGame.Utils
{
    public static class FileHelper
    {
        public static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static string ReadFromFile(string path)
        {
            return File.Exists(path) ? File.ReadAllText(path) : string.Empty;
        }
    }
}
