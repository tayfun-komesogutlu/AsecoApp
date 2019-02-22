using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseco_Winform.Dto
{
    public class Log
    {
        public long Line { get; set; }
        public List<LogDetail> Details { get; set; }
        public Log()
        {
            Details = new List<LogDetail>();
        }
    }
    public class LogDetail
    {
        public string ColumnName { get; set; }
        public string ErrorDescription { get; set; }
    }
}
