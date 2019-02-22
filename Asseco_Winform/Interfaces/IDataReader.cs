using Asseco_Winform.Dto;

namespace Asseco_Winform.Interfaces
{
    public interface IDataReader
    {
        DataReaderOutput ReadData(DataReaderInput inputfile);

    }
}
