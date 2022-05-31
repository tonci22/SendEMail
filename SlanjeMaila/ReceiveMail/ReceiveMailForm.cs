using System;
using System.Windows.Forms;

namespace SlanjeMaila.ReceiveMail
{
    public partial class ReceiveMailForm : Form
    {
        System.Windows.Forms.Timer tajmer;
        public ReceiveMailForm()
        {
            InitializeComponent();
            tajmer = new Timer();
        }

        private void ReceiveMailForm_Load(object sender, EventArgs e)
        {
            tajmer.Interval = 30;
            tajmer.Tick += new EventHandler(tajmer_Tick);
            tajmer.Start();
        }
        private void tajmer_Tick(object sender, EventArgs e)
        {
            MailReceive.Instance.ReceiveMail(MailSend.Instance.MojMail, 587, true);
            lblMessage.Text = MailReceive.Instance.BodyMessage;
        }
    }
}
