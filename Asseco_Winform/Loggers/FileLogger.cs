using Asseco_Winform.Dto;
using Asseco_Winform.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Asseco_Winform.Loggers
{
    internal sealed class FileLogger : ILogger
    {
        private static FileLogger _logger;
        private static IFileProcesses _fileProcesses;
        public FileLogger(IFileProcesses fileProcesses)
        {
            _fileProcesses = fileProcesses;
        }
        //Singleton Design Pattern
        public static FileLogger GetLogger()
        {
            if (_logger == null)
                _logger = new FileLogger(_fileProcesses);
            return _logger;
        }
        public void SaveLogs(List<Log> log, string logPath)
        {
            var headerMessage = $"{DateTime.UtcNow} ";
            var path = Path.Combine(logPath, "AssecoDataReaderLog.txt");

            var sb = new StringBuilder();

            sb.Append(headerMessage).AppendLine();

            foreach (var logItem in log.Where(x => x != null).OrderBy(x => x.Line))
            {
                sb.Append($"Satır : {logItem.Line}");
                foreach (var logDetail in logItem.Details)
                {
                    sb.Append($"\t{logDetail.ColumnName}: {logDetail.ErrorDescription}");
                }
                sb.AppendLine();
            }
            _fileProcesses.GenerateFile(sb.ToString(), path);
        }
    }
}
