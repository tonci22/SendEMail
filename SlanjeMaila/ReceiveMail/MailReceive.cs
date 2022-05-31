using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Pop3;
using OpenPop.Mime;


/*TODO 
treba pun kurac stvari, neda mi se
samo san hti da mogu poslat
*/
namespace SlanjeMaila
{
    class MailReceive
    {
        private static MailReceive instance;
        public static MailReceive Instance => instance == null ? instance = new MailReceive() : instance;

        public string BodyMessage { get; set; } = "";
        public string HeaderMessage { get; set; } = "";

        public void ReceiveMail(string hostname, int port, bool ssl)
        {
            try
            {
                using (Pop3Client klijent = new Pop3Client())
                {
                    klijent.Connect("pop.live.com", 587, true);
                    klijent.Authenticate("ante.milina@hotmail.com", "ODE STAVIT SIFRU");
                    Message message = klijent.GetMessage(klijent.GetMessageCount());
                    BodyMessage = message.MessagePart.Body.ToString();
                }
            }
            catch { }             
        }

    }
}
