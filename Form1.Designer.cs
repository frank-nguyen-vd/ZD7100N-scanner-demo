namespace scanner_demo
{
    partial class Main
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.Label();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.btnRetrieveData = new System.Windows.Forms.Button();
            this.txtScannedData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(28, 31);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 31);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // txtComPort
            // 
            this.txtComPort.Location = new System.Drawing.Point(205, 31);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(59, 20);
            this.txtComPort.TabIndex = 2;
            this.txtComPort.Text = "17";
            this.txtComPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(205, 57);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(59, 20);
            this.txtBaudRate.TabIndex = 4;
            this.txtBaudRate.Text = "115200";
            this.txtBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud Rate";
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(186, 83);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(78, 31);
            this.txtClose.TabIndex = 5;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.AutoSize = true;
            this.txtConnectionStatus.Location = new System.Drawing.Point(71, 9);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(58, 13);
            this.txtConnectionStatus.TabIndex = 6;
            this.txtConnectionStatus.Text = "Not Ready";
            // 
            // btnStartScan
            // 
            this.btnStartScan.Location = new System.Drawing.Point(28, 127);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(78, 31);
            this.btnStartScan.TabIndex = 7;
            this.btnStartScan.Text = "Start Scan";
            this.btnStartScan.UseVisualStyleBackColor = true;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // btnStopScan
            // 
            this.btnStopScan.Location = new System.Drawing.Point(186, 202);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.Size = new System.Drawing.Size(78, 31);
            this.btnStopScan.TabIndex = 9;
            this.btnStopScan.Text = "Stop Scan";
            this.btnStopScan.UseVisualStyleBackColor = true;
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click);
            // 
            // btnRetrieveData
            // 
            this.btnRetrieveData.Location = new System.Drawing.Point(28, 202);
            this.btnRetrieveData.Name = "btnRetrieveData";
            this.btnRetrieveData.Size = new System.Drawing.Size(78, 31);
            this.btnRetrieveData.TabIndex = 10;
            this.btnRetrieveData.Text = "Retrieve";
            this.btnRetrieveData.UseVisualStyleBackColor = true;
            this.btnRetrieveData.Click += new System.EventHandler(this.btnRetrieveData_Click);
            // 
            // txtScannedData
            // 
            this.txtScannedData.Location = new System.Drawing.Point(28, 176);
            this.txtScannedData.Name = "txtScannedData";
            this.txtScannedData.Size = new System.Drawing.Size(236, 20);
            this.txtScannedData.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 263);
            this.Controls.Add(this.txtScannedData);
            this.Controls.Add(this.btnRetrieveData);
            this.Controls.Add(this.btnStopScan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Label txtConnectionStatus;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStopScan;
        private System.Windows.Forms.Button btnRetrieveData;
        private System.Windows.Forms.TextBox txtScannedData;
    }
}

