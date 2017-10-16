namespace Spelling.Bll.Abstract
{
    public interface IFileHelper
    {
        string LoadFileToText(string filePath);
        void SaveTextToFile(string filepath, string text);
    }
}