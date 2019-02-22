namespace Asseco_Winform
{
    partial class AssecoUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.btnSelectDataFile = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.btnSearchSubscirber = new System.Windows.Forms.Button();
            this.txtSubscriberNo = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.fdDataImport = new System.Windows.Forms.OpenFileDialog();
            this.fbLogFileSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.lblDataPath = new System.Windows.Forms.Label();
            this.lblLogPath = new System.Windows.Forms.Label();
            this.grpHeader.SuspendLayout();
            this.grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHeader
            // 
            this.grpHeader.Controls.Add(this.lblLogPath);
            this.grpHeader.Controls.Add(this.lblDataPath);
            this.grpHeader.Controls.Add(this.btnSave);
            this.grpHeader.Controls.Add(this.btnLogFile);
            this.grpHeader.Controls.Add(this.btnSelectDataFile);
            this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHeader.Location = new System.Drawing.Point(0, 0);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(800, 155);
            this.grpHeader.TabIndex = 0;
            this.grpHeader.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogFile
            // 
            this.btnLogFile.Location = new System.Drawing.Point(318, 33);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(151, 51);
            this.btnLogFile.TabIndex = 1;
            this.btnLogFile.Text = "Log Klasörü";
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // btnSelectDataFile
            // 
            this.btnSelectDataFile.Location = new System.Drawing.Point(84, 33);
            this.btnSelectDataFile.Name = "btnSelectDataFile";
            this.btnSelectDataFile.Size = new System.Drawing.Size(151, 51);
            this.btnSelectDataFile.TabIndex = 0;
            this.btnSelectDataFile.Text = "Veri Dosyası";
            this.btnSelectDataFile.UseVisualStyleBackColor = true;
            this.btnSelectDataFile.Click += new System.EventHandler(this.btnSelectDataFile_Click);
            // 
            // grpContent
            // 
            this.grpContent.Controls.Add(this.btnSearchSubscirber);
            this.grpContent.Controls.Add(this.txtSubscriberNo);
            this.grpContent.Controls.Add(this.grdData);
            this.grpContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpContent.Location = new System.Drawing.Point(0, 161);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(800, 403);
            this.grpContent.TabIndex = 1;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "Abone Listesi";
            // 
            // btnSearchSubscirber
            // 
            this.btnSearchSubscirber.Location = new System.Drawing.Point(561, 21);
            this.btnSearchSubscirber.Name = "btnSearchSubscirber";
            this.btnSearchSubscirber.Size = new System.Drawing.Size(215, 46);
            this.btnSearchSubscirber.TabIndex = 2;
            this.btnSearchSubscirber.Text = "Abone Ara";
            this.btnSearchSubscirber.UseVisualStyleBackColor = true;
            this.btnSearchSubscirber.Click += new System.EventHandler(this.btnSearchSubscirber_Click);
            // 
            // txtSubscriberNo
            // 
            this.txtSubscriberNo.Location = new System.Drawing.Point(29, 33);
            this.txtSubscriberNo.Name = "txtSubscriberNo";
            this.txtSubscriberNo.Size = new System.Drawing.Size(497, 22);
            this.txtSubscriberNo.TabIndex = 1;
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(29, 75);
            this.grdData.Name = "grdData";
            this.grdData.RowTemplate.Height = 24;
            this.grdData.Size = new System.Drawing.Size(747, 314);
            this.grdData.TabIndex = 0;
            // 
            // fdDataImport
            // 
            this.fdDataImport.Filter = "txt files (*.txt)|*.txt";
            // 
            // lblDataPath
            // 
            this.lblDataPath.AutoSize = true;
            this.lblDataPath.Location = new System.Drawing.Point(26, 96);
            this.lblDataPath.Name = "lblDataPath";
            this.lblDataPath.Size = new System.Drawing.Size(0, 17);
            this.lblDataPath.TabIndex = 3;
            // 
            // lblLogPath
            // 
            this.lblLogPath.AutoSize = true;
            this.lblLogPath.Location = new System.Drawing.Point(26, 124);
            this.lblLogPath.Name = "lblLogPath";
            this.lblLogPath.Size = new System.Drawing.Size(0, 17);
            this.lblLogPath.TabIndex = 4;
            // 
            // AssecoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.grpHeader);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssecoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asseco UI";
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            this.grpContent.ResumeLayout(false);
            this.grpContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.Button btnSearchSubscirber;
        private System.Windows.Forms.TextBox txtSubscriberNo;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.Button btnLogFile;
        private System.Windows.Forms.Button btnSelectDataFile;
        private System.Windows.Forms.OpenFileDialog fdDataImport;
        private System.Windows.Forms.FolderBrowserDialog fbLogFileSelect;
        private System.Windows.Forms.Label lblLogPath;
        private System.Windows.Forms.Label lblDataPath;
    }
}

