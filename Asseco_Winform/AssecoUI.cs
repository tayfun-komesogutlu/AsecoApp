using Asseco_Winform.DataReaders;
using Asseco_Winform.Dto;
using Asseco_Winform.Extension;
using Asseco_Winform.Interfaces;
using Asseco_Winform.Loggers;
using Asseco_Winform.Repositories;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Asseco_Winform
{
    public partial class AssecoUI : Form
    {
        public AssecoUI()
        {
            InitializeComponent();
        }
        #region Properties
        private readonly IFileProcesses fileProcesses = null;
        private readonly ILogger logger = null;
        public static string dataFileName { get; set; }
        public static string logFileName { get; set; }
        private DataReaderOutput output;
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataFileName))
                MessageBox.Show("Lütfen veri dosya seçiniz","Info");
            if (string.IsNullOrEmpty(logFileName))
                MessageBox.Show("Lütfen log klasör yolu seçiniz","Info");
            else
            {
                var input = new DataReaderInput { FilePath = dataFileName };
                Interfaces.IDataReader txtReader = new TxtReaderRepository(new FileProcessesRepository(), new LoggerRepository());
                ILogger logger = new FileLogger(new FileProcessesRepository());
                output = txtReader.ReadData(input);
                var customerInfo = output.Items.Where(x => x != null).SelectMany(x => x.CustumerInfos).ToList();
                var logs = output.Items.Where(x => x != null).SelectMany(x => x.Logs).ToList();

                logger.SaveLogs(logs, logFileName);

                MessageBox.Show($"Kaydedilen Abone Sayısı:\t{customerInfo.Count}\nHatalı Abone Sayısı:\t{logs.Count}","Info");
                Process.Start(logFileName + "/AssecoDataReaderLog.txt");
            }
        }

        private void btnSelectDataFile_Click(object sender, EventArgs e)
        {
            if (fdDataImport.ShowDialog() == DialogResult.OK)
            {
                dataFileName = fdDataImport.FileName.BeautifierPath();
                lblDataPath.Text = $"Veri dosyası : {dataFileName}";
            }
        }

        private void btnLogFile_Click(object sender, EventArgs e)
        {
            if (fbLogFileSelect.ShowDialog() == DialogResult.OK)
            {
                logFileName = fbLogFileSelect.SelectedPath.BeautifierPath();
                lblLogPath.Text = $"Log Dosyası : {logFileName}";
            }
        }

        private void btnSearchSubscirber_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubscriberNo.Text) && output != null)
            {
                var query = output.Items.Where(x => x != null).SelectMany(x => x.CustumerInfos);
                var list = query.Where(x => x.SubscriberNumber.Contains(txtSubscriberNo.Text))
                    .GroupBy(x => x.BillNo).Select(x => new
                    {
                        AboneNumarası = x.Key,
                        ToplamBorc = x.Sum(o => o.DebtLoadingAmount)
                    }).ToList();
                grdData.DataSource = list;
            }
            else
            {
                MessageBox.Show("Lütfen Abone numarasını kontrol ediniz.","Info");
            }
        }
    }
}
