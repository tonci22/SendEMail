using System;
using System.Windows.Forms;

namespace SlanjeMaila
{
    class NePodrzavaProvideraException : Exception
    {
        public NePodrzavaProvideraException(string provider)
        {
            MessageBox.Show("trenutno ovi kurac ne podrzava '" + provider + "' providera","PROVIDER");
        }
        public NePodrzavaProvideraException()
        {
            
        }
    }
}
