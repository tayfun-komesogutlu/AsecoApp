using Asseco_Winform.Interfaces;
using System.IO;
using System.Text;

namespace Asseco_Winform.Repositories
{
    public class FileProcessesRepository : IFileProcesses
    {
        public void GenerateFile(string text, string path)
        {
            using (var fStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                var bStream = new BufferedStream(fStream);
                var writer = new StreamWriter(bStream,Encoding.UTF8);

                writer.WriteLine(text);

                bStream.Flush();
                writer.Flush();
                fStream.Flush();
            }
        }

        public string[] GetFileLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
