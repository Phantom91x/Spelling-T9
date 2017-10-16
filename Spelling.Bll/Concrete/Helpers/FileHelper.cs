using System.IO;
using Spelling.Bll.Abstract;

namespace Spelling.Bll.Helpers
{
    /// <summary>
    /// Helper for work with files
    /// </summary>
    public class FileHelper : IFileHelper
    {
        public string LoadFileToText(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            return System.IO.File.ReadAllText(filePath);
        }

        public void SaveTextToFile(string filepath, string text)
        {
            System.IO.File.WriteAllText(filepath, text);
        }
    }
}