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
        public Main()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int port = 0;
            int bandrate = 0;
            int hd = 0;
            byte[] resp = new byte[64];
            port = 17;
            bandrate = 115200;
            hd = Scan.OpenScaner(port, bandrate);            
            if (hd > 0)
            {                
                MessageBox.Show("Connect to the device successfully", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // 
            else
                MessageBox.Show("Fail to connect to the device", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
