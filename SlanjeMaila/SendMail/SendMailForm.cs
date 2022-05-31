using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlanjeMaila
{
    public partial class SendMailForm : Form
    {
        System.Windows.Forms.Timer tajmer;
        public SendMailForm()
        {
            InitializeComponent();
            tajmer = new System.Windows.Forms.Timer();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tajmer.Interval = 30;
            tajmer.Tick += new EventHandler(tajmer_Tick);
            tajmer.Start();
        }

        private void tajmer_Tick(object sender, EventArgs e)
        {
            lblStatusPoruke.Text = ThreadSettings.Instance.StanjeDretve();
            ThreadSettings.Instance.ProgressBarDretve(progBarPoruka);
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            MailSend.Instance.UnosPodatakaMaila(unosPosiljatelja.Text, unosPrimatelja.Text, unosSubject.Text, unosSifra.Text);

            ThreadSettings.Instance.NovaDretva(unosPoruke.Text);
            ThreadSettings.Instance.PokrecanjeDretve();

            if (MailSend.Instance.GmailEnableMailReceive())
            {
                GmailEnable prikaziGmailNotification = new GmailEnable();       //ako inic, izvan if-a onda mi se disposa ako opet pokrenen
                prikaziGmailNotification.Show();
            }
            lblImeAttachmenta.Text = "No Att.";
        }

        private void AnteMilinaHotmailCom_Click(object sender, EventArgs e)
        {
            unosPosiljatelja.Text = MailAccounts.AnteHotmail();
        }

        private void jebemuboga123GmailCom_Click(object sender, EventArgs e)
        {
            unosPosiljatelja.Text = MailAccounts.AnteGmail();
        }

        private void antmilinafoihrSendTo_Click(object sender, EventArgs e)
        {
            unosPrimatelja.Text = MailAccounts.AnteFoi();
        }

        private void antemilinahotmailcomSendTo_Click(object sender, EventArgs e)
        {
            unosPrimatelja.Text = MailAccounts.AnteHotmail();
        }

        private void jebemuboga123gmailcomSendTo_Click(object sender, EventArgs e)
        {
            unosPrimatelja.Text = MailAccounts.AnteGmail();
        }

        private void bzvzTempDefault_Click(object sender, EventArgs e)
        {
            unosSubject.Text = "subject1";
            unosPoruke.Text = "random text. kjfdsdv gksdfsadkjhfksd f ksdrzhfgš šurrveuveru";
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            if (dialogAttachment.ShowDialog() == DialogResult.OK)
            {
                MailSend.Instance.putDoAttachmenta = new System.Net.Mail.Attachment(dialogAttachment.FileName);
                lblImeAttachmenta.Text = dialogAttachment.SafeFileName;
            }
        }

        private void btnPromjenaFontaPoruke_Click(object sender, EventArgs e)
        {
            if (dialogFont.ShowDialog() == DialogResult.OK)
            {
                unosPoruke.Font = new Font(dialogFont.Font.FontFamily, dialogFont.Font.Size, dialogFont.Font.Style);
                MailFonts.MailFont(unosPoruke.Font);
            }
        }

        private void newMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMail();
        }

        private void NewMail()
        {
            unosPoruke.Text = "";
            unosPoruke.Font = new Font("Arial", 12);
            unosPosiljatelja.Text = "";
            unosPrimatelja.Text = "";
            unosSifra.Text = "";
            unosSubject.Text = "";
            dialogAttachment.FileName = "";
            lblImeAttachmenta.Text = "No Att.";
            resetDialogs();
            MailSend.Instance.NoviMail();
        }

        //ovo mi se cini i netreba posto san stavi da je background = true
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ThreadSettings.Instance.DretvaZaSlanjeMaila != null)
            {
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Abort();
            }
            //ThreadSettings.Instance.DretvaZaSlanjeMaila.Interrupt();   
        }
        private void resetDialogs()
        {
            dialogAttachment.Reset();
            dialogFont.Reset();
        }
    }
}
