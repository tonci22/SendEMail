using System;
using System.Threading;
using System.Windows.Forms;

namespace SlanjeMaila
{
    class ThreadSettings
    {
        private static ThreadSettings instance;
        public static ThreadSettings Instance => instance == null ? instance = new ThreadSettings() : instance;

        public Thread DretvaZaSlanjeMaila { get; set; }
        private delegate void slanjeMailaDelegat(string poruka);

        public void NovaDretva(string porukaZaPoslat)
        {
            slanjeMailaDelegat saljiMail = new slanjeMailaDelegat(MailSend.Instance.SaljiPoruku);
            //DretvaZaSlanjeMaila = new Thread(
            //delegate ()
            //{
            //    control.Invoke((MethodInvoker)
            //        delegate
            //        {
            //            control.Text = porukaZaPoslat;
            //        });
            //    saljiMail(porukaZaPoslat);
            //});
            DretvaZaSlanjeMaila = new Thread(() => saljiMail(porukaZaPoslat));
            DretvaZaSlanjeMaila.IsBackground = true;
        }

        public void PokrecanjeDretve()
        {
            DretvaZaSlanjeMaila.Start();
        }

        public string StanjeDretve()
        {
            string poruka = "";
            if (DretvaZaSlanjeMaila != null)
            {
                if (DretvaZaSlanjeMaila.ThreadState == ThreadState.Background)
                {
                    poruka = "Slanje poruke...";
                }
                else if (DretvaZaSlanjeMaila.ThreadState == ThreadState.Stopped)
                {
                    poruka = "Poruka Poslana";
                }
                else
                {
                    poruka = "Ni uspilo poslat poruku";
                }
            }
            return poruka;
        }
        public void ProgressBarDretve(ToolStripProgressBar progressbar)
        {
            Random randIncrement = new Random();
            if(DretvaZaSlanjeMaila != null)
            {
                try
                {
                    if (DretvaZaSlanjeMaila.ThreadState == ThreadState.Background)
                    {
                        //maximum je 400, sve se mnozi sa 4
                        if (progressbar.Value <= 320)
                        {
                            progressbar.Increment(randIncrement.Next(0, 3));
                        }
                        else if (progressbar.Value > 320 && progressbar.Value < 390)
                        {
                            progressbar.Increment(randIncrement.Next(0, 2));
                        }
                        else if (progressbar.Value == 400)
                        {
                            progressbar.Value = 0;
                        }
                    }
                    else if (DretvaZaSlanjeMaila.ThreadState == ThreadState.Stopped)
                    {
                        progressbar.Value = 400;
                    }
                    else
                    {
                        progressbar.Value = 0;
                    }
                }
                catch { }
            }
        }
    }
}
