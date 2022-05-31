using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlanjeMaila
{
    public partial class MainForm : Form
    {
        SendMailForm sendMailForm;
        ReceiveMail.ReceiveMailForm receiveMailForm;
        public MainForm()
        {
            InitializeComponent();
            btnReceiveMailForm.Enabled = false;
        }

        private void btnSendMailForm_Click(object sender, EventArgs e)
        {
            sendMailForm = new SendMailForm();
            sendMailForm.Show();
        }

        private void btnReceiveMailForm_Click(object sender, EventArgs e)
        {
            receiveMailForm = new ReceiveMail.ReceiveMailForm();
            receiveMailForm.Show();
        }
    }
}
