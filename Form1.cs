using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scanner_demo
{
    public partial class Main : Form
    {
        private int scanner;

        public Main()
        {
            InitializeComponent();

            // User Initialization
            scanner = 0;
        }

        private void showMessage(string msg, string severity)
        {
            txtConnectionStatus.Text = msg;
            switch (severity)
            {
                case "error":
                    txtConnectionStatus.ForeColor = Color.Red;
                    break;
                case "warning":
                    txtConnectionStatus.ForeColor = Color.Orange;
                    break;
                case "info":
                    txtConnectionStatus.ForeColor = Color.Blue;                    
                    break;
                default:
                    txtConnectionStatus.ForeColor = Color.Black;                    
                    break;
            }
        }

        private void connectScanner()
        {
            int port = 0;
            int baudrate = 0;

            if (scanner > 0)
            {
                showMessage("Please turn off the connection first", "warning");
                return;
            }

            port = Convert.ToInt32(txtComPort.Text);
            baudrate = Convert.ToInt32(txtBaudRate.Text);
            scanner = Scan.OpenScaner(port, baudrate);
            if (scanner > 0)
            {
                showMessage("Connect to device successfully", "info");
            }
            else
            {
                showMessage("Fail to connect to device", "error");
            }
        }

        private void closeScanner()
        {
            int status;
            status = Scan.CloseScaner(scanner);
            if (scanner == 0)
            {
                showMessage("No active connection", "warning");
                return;
            }

            if (status != 0)
            {
                showMessage("Device is turned off", "info");
                scanner = 0;
            }
            else
            {
                showMessage("Cannot turn off device", "error");
            }
        }

        private void startScan()
        {
            int status = Scan.ScanStart(scanner);
            if (status > 0)
            {
                showMessage("Start scanning", "info");
            }
            else
            {
                showMessage("Fail to start scanning", "error");
            }
        }

        private void stopScan()
        {
            int status = Scan.ScanClose(scanner);
            if (status > 0)
            {
                showMessage("Stop scanning", "info");
            }
            else
            {
                showMessage("Fail to stop scanning", "error");
            }
                
        }

        private void btnRetrieveData_Click(object sender, EventArgs e)
        {
            byte[] buf = new byte[1024];
            int status;

            status = 0;
            txtScannedData.Text = "";
                status = Scan.ScanDateReceiced(scanner, ref buf[0]);
                if (status > 0)
                {
                    string res;
                    res = System.Text.Encoding.Default.GetString(buf);
                    if (res != txtScannedData.Text) txtScannedData.Text = res;
                    showMessage("Data retrieved", "info");
                }
                else
                {
                    showMessage("Fail to retrieve data", "error");
                }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connectScanner();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            closeScanner();
        }

        private void btnStartScan_Click(object sender, EventArgs e)
        {
            startScan();
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            stopScan();
        }
    }
}
