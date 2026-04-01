using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10___Assignment_10
{
    public partial class FormAddResource : Form
    {
        public FormAddResource()
        {
            InitializeComponent();
        }


        private void btnRAM_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.RAM;
            lblInfo.Text = "• Measured in GB\r\n• Stores what you are working on but haven’t saved\r\n• Stores the instrucons for all running applicaons\r\n• Stores any content that is ‘open’\r\n• Is extremely fast to keep up with CPU\r\n• Volatile\r\n• Small amount of memory\r\n";
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.SSD;
            lblInfo.Text = "• Measured in TB\r\n• Stores all of your files for the long term\r\n(when your device is off)\r\n• All types of secondary memory are\r\nextremely slow compared to RAM\r\n• Some types of secondary memory are\r\nfaster than others.\r\n• Large amounts of memory rela)ve to\r\nprimary memory.";
        }

        private void btnPSU_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.PowerSupply;
            lblInfo.Text = "A Power Supply Unit (PSU) converts high-voltage \r\nalternating current (AC) from a wall outlet into \r\nlow-voltage direct current (DC) needed for \r\ncomputer components to operate.\r\n";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.Input;
            lblInfo.Text = "An input peripheral device is external hardware \r\nused to send data, signals, and instructions to a \r\ncomputer, allowing users to interact with and \r\ncontrol the system.\r\n";
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.Output;
            lblInfo.Text = "An output peripheral device receives processed data \r\nfrom a computer and presents it in a \r\nhuman-understandable form, such as text, graphics, \r\nor audio.\r\n.";
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            ImgComponents.Image = Properties.Resources.CPU;
            lblInfo.Text = "A CPU (Central Processing Unit) is the \"brain\" of a \r\ncomputer, responsible for fetching, decoding, and \r\nexecuting instructions to process data and manage\r\n system components.\r\n";
        }
    }
}
