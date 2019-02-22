using Asseco_Winform.Dto;
using Asseco_Winform.Interfaces;
using System;
using System.Collections.Generic;

namespace Asseco_Winform.Loggers
{
    internal class DbLogger : ILogger
    {
        //this method could use when want to keep data on database 
        public void SaveLogs(List<Log> log, string logPath)
        {
            throw new NotImplementedException();
        }
    }
}
