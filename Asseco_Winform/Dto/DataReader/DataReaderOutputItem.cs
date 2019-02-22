using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Asseco_Winform.Dto
{
    [DataContract]
    public class DataReaderOutputItem
    {
        [DataMember]
        public List<CustomerInfoDto> CustumerInfos { get; set; }
        [DataMember]
        public List<Log> Logs { get; set; }

        public DataReaderOutputItem()
        {
            CustumerInfos = new List<CustomerInfoDto>();
            Logs = new List<Log>();
        }
    }
}
