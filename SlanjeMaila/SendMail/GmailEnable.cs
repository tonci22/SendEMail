using System;
using System.Windows.Forms;

namespace SlanjeMaila
{
    public partial class GmailEnable : Form
    {
        public GmailEnable()
        {
            InitializeComponent();
        }

        private void linkGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://myaccount.google.com/lesssecureapps");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkBxEnable_CheckedChanged(object sender, EventArgs e)
        {
            MailSend.Instance.chkbxEnable = !MailSend.Instance.chkbxEnable;
        }
    }
}
