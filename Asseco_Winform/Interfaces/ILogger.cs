using Asseco_Winform.Dto;
using System.Collections.Generic;
using System.Reflection;

namespace Asseco_Winform.Interfaces
{
    public interface ILogger
    {
        void SaveLogs(List<Log> log, string logPath);
    }
}
