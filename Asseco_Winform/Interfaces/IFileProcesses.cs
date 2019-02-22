using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco_Winform.Interfaces
{
    public interface IFileProcesses
    {
        string[] GetFileLines(string path);
        void GenerateFile(string text, string path);
    }
}
