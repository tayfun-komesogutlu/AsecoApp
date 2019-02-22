using Asseco_Winform.Dto;
using Asseco_Winform.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asseco_Winform.DataReaders
{
    internal class TxtReaderRepository : IDataReader
    {
        private readonly IFileProcesses _fileProcesses;
        private readonly ILogger _logger;

        public TxtReaderRepository(IFileProcesses fileProcesses, ILogger logger)
        {
            _fileProcesses = fileProcesses;
            _logger = logger;
        }


        public DataReaderOutput ReadData(DataReaderInput input)
        {
            var output = new DataReaderOutput();

            var lines = _fileProcesses.GetFileLines(input.FilePath);
            var parallelOptions = new ParallelOptions
            {
                MaxDegreeOfParallelism = 5
            };

            Parallel.For(1, lines.Length, parallelOptions, index =>
            {
                output.Items.Add(GetCustomerInfo(index + 1, lines[index]));
            });
            return output;
        }


        private DataReaderOutputItem GetCustomerInfo(int index, string data)
        {
            var outputItem = new DataReaderOutputItem();

            if (data.Trim().Length != 61 || string.IsNullOrEmpty(data.Trim()))
            {
                outputItem.Logs.Add(new Log
                {
                    Line = index,
                    Details = new List<LogDetail>() { new LogDetail { ColumnName = "", ErrorDescription = "Karakter sayısı 61 olmalı!" } }
                });
                return outputItem;
            }

            #region SeperateField
            var subscriberNo = data.Substring(1, 9);
            var debt = data.Substring(18, 15);
            var dueDate = data.Substring(33, 10);
            var period = data.Substring(46, 4);
            var billNumber = data.Substring(50, 11);
            #endregion

            #region Validation
            if (!int.TryParse(subscriberNo, out var _subscriberNo))
                outputItem.Logs.Add(new Log { Line = index, Details = new List<LogDetail> { new LogDetail { ColumnName = "Abone No", ErrorDescription = "Data tipi hatalı" } } });
            if (!decimal.TryParse(debt, out var _debt))
            {
                if (outputItem.Logs.Count == 0)
                {
                    outputItem.Logs.Add(new Log
                    {
                        Line = index,
                        Details = new List<LogDetail> { new LogDetail { ColumnName = "Borç Yükleme Tutarı", ErrorDescription = "Data tipi hatalı" } }
                    });
                }
                else
                {
                    outputItem.Logs[0].Details.Add(new LogDetail
                    {
                        ColumnName = "Borç Yükleme Tutarı",
                        ErrorDescription = "Data tipi hatalı"
                    });
                }
            }
            if (!DateTime.TryParse(dueDate, out var _dueDate))
            {
                if (outputItem.Logs.Count == 0)
                {
                    outputItem.Logs.Add(new Log
                    {
                        Line = index,
                        Details = new List<LogDetail> { new LogDetail { ColumnName = "Son ödeme tarihi", ErrorDescription = "Data tipi hatalı" } }
                    });
                }
                else
                {
                    outputItem.Logs[0].Details.Add(new LogDetail
                    {
                        ColumnName = "Son ödeme tarihi",
                        ErrorDescription = "Data tipi hatalı"
                    });
                }
            }
            if (!int.TryParse(period, out var _period))
            {
                if (outputItem.Logs.Count == 0)
                {
                    outputItem.Logs.Add(new Log
                    {
                        Line = index,
                        Details = new List<LogDetail> { new LogDetail { ColumnName = "Dönem Yıl", ErrorDescription = "Data tipi hatalı" } }
                    });
                }
                else
                {
                    outputItem.Logs[0].Details.Add(new LogDetail
                    {
                        ColumnName = "Dönem Yıl",
                        ErrorDescription = "Data tipi hatalı"
                    });
                }
            }
            #endregion
            
            if (outputItem.Logs.Count == 0)
                outputItem.CustumerInfos.Add(new CustomerInfoDto { BillNo = billNumber, TermYear = period, LastPaymentDate = DateTime.Parse(dueDate), DebtLoadingAmount = decimal.Parse(debt), SubscriberNumber = subscriberNo });
            else
                return outputItem;

            return outputItem;
        }

    }
}
