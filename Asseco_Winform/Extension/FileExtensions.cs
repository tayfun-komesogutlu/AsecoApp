using System.IO;

namespace Asseco_Winform.Extension
{
    public static class FileExtensions
    {
        public static string BeautifierPath(this string path)
        {
            var standardCount = 150;
            var newPath = path;
            if (path.Length > standardCount)
            {
                var fileName = Path.GetFileName(path);
                var directoryName = new DirectoryInfo(path).Parent;

                if (fileName.Length > standardCount)
                {
                    newPath = $"{fileName.Remove(standardCount)}...";
                }
                else
                {
                    newPath = $"{path.Remove(standardCount - fileName.Length)}...\\{fileName}";
                }
            }
            return newPath;
        }
    }
}
