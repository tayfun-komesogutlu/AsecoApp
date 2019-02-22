using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Asseco_Winform.Dto
{
    [DataContract]
    public class DataReaderOutput
    {
        public DataReaderOutput()
        {
            Items = new List<DataReaderOutputItem>();
        }
        [DataMember]
        public IList<DataReaderOutputItem> Items { get; set; }
    }
}
