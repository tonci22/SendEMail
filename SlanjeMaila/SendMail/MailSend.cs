using System;
using System.Net.Mail;
using System.Windows.Forms;
using System.Net;

namespace SlanjeMaila
{
    class MailSend
    {
        private static MailSend instance;
        public static MailSend Instance => instance == null ? instance = new MailSend() : instance;
        public string MojMail { get; set; } = "";
        public string TvojMail { get; set; } = "";
        public string Subject { get; set; } = "";
        public string SifraMail { get; set; } = "";
        public Attachment putDoAttachmenta = null;
        public bool chkbxEnable = true;
        private string host { get; set; } = "";
        private int port { get; set; } = 0;

        public void ProvjeraMailPosluzitelja()
        {
            string mailProvider = "";
            for (int i = MojMail.IndexOf('@') + 1; i < MojMail.Length; i++)
            {
                mailProvider += MojMail[i];
            }

            switch (mailProvider)
            {
                case "hotmail.com":
                    host = "smtp.live.com";
                    port = 587;
                    break;
                case "outlook.com":
                    host = "smtp.live.com";
                    port = 587;
                    break;
                case "gmail.com":
                    host = "smtp.gmail.com";
                    port = 587;
                    break;
                case "yahoo.com":
                    host = "Smtp.mail.yahoo.com";
                    port = 465;
                    break;
                case "verizon.net":
                    host = "outgoing.verizon.net";
                    port = 465;
                    break;
                case "1and1.com":
                    host = "smtp.1and1.com";
                    port = 587;
                    break;
                case "comcast.net":
                    host = "smtp.comcast.net";
                    port = 587;
                    break;
                case "orange.com":
                    host = "smtp.orange.net";
                    port = 465;
                    break;
                case "virgin.net":
                    host = "smtp.virgin.net";
                    port = 465;
                    break;
                case "att.net":
                    host = "outbound.att.net";
                    port = 587;
                    break;
                case "airmail.net":
                    host = "mail.airmail.net";
                    port = 587;
                    break;
                case "aol.com":
                    host = "smtp.aol.com";
                    port = 587;
                    break;
                default:
                    try
                    {
                        throw new NePodrzavaProvideraException(mailProvider);
                    }
                    catch { }
                    break;
            }
        }

        public void SaljiPoruku(String poruka)
        {
            try
            {
                using (MailMessage message = new MailMessage(MojMail, TvojMail))
                {
                    message.Subject = Subject;
                    message.IsBodyHtml = true;
                    message.Body = MailFonts.Convert(poruka);
                    if (putDoAttachmenta != null) message.Attachments.Add(putDoAttachmenta);
                    ProvjeraMailPosluzitelja();
                    using (SmtpClient klijent = new SmtpClient(host, port))
                    {
                        klijent.Credentials = new NetworkCredential(MojMail, SifraMail);
                        klijent.EnableSsl = true;
                        klijent.Send(message);
                    }
                }
                GmailEnableMailReceive();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("nisi sve ispuni", "nes je sjebano", MessageBoxButtons.OK);
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Join();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("provjeri jeli sve dobro ispunjeno (pogotovo za tvoj mail i password)", "nes je sjebano", MessageBoxButtons.OK);
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Join();
            }
            catch (SmtpFailedRecipientsException)
            {
                MessageBox.Show("NES OD OVEGA: \n1. krivi 'tvoj mail' i/ili 'sifra' \n2. konekcija ni uspila \n3. isteklo vrime operacije \n4. nes u vezi SSL-a, sta ja znn", "nes je sjebano", MessageBoxButtons.OK);
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Join();
            }
            catch (SmtpException)
            {
                MessageBox.Show("ni uspi poslat, provjeri 'tvoj mail' i 'sifru'", "nes je sjebano", MessageBoxButtons.OK);
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Join();
            }
            catch (FormatException)
            {
                MessageBox.Show("krivi format mailova", "nes je sjebano", MessageBoxButtons.OK);
                ThreadSettings.Instance.DretvaZaSlanjeMaila.Join();
            }
            finally
            {
                putDoAttachmenta = null;
            }
        }

        public void UnosPodatakaMaila(string mojMail, string tvojMail, string subject, string sifraMail)
        {
            MojMail = mojMail;
            TvojMail = tvojMail;
            Subject = subject;
            SifraMail = sifraMail;
        }

        public bool GmailEnableMailReceive()
        {
            if (TvojMail.Contains("gmail.com") && chkbxEnable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void NoviMail()
        {
            MojMail = "";
            TvojMail = "";
            Subject = "";
            SifraMail = "";
            putDoAttachmenta = null;
        }
    }
}
