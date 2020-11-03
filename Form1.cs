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

        private void showConnectionStatus(string msg, string severity)
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int port = 0;
            int baudrate = 0;            

            if (scanner > 0)
            {
                showConnectionStatus("Please turn off the connection first", "warning");
                return;
            }

            port = Convert.ToInt32(txtComPort.Text);
            baudrate = Convert.ToInt32(txtBaudRate.Text);
            scanner = Scan.OpenScaner(port, baudrate);
            if (scanner > 0)
            {
                showConnectionStatus("Connect to device successfully", "info");
            } else
            {
                showConnectionStatus("Fail to connect to device", "error");
            }
                
        }

        private void txtTurnOff_Click(object sender, EventArgs e)
        {
            int status;
            status = Scan.CloseScaner(scanner);
            if (scanner == 0)
            {
                showConnectionStatus("No active connection", "warning");
                return;
            }

            if (status != 0)
            {
                showConnectionStatus("Device is turned off", "info");
                scanner = 0;
            } else
            {
                showConnectionStatus("Cannot turn off device", "error");
            }
            
        }
    }
}
