using System.Drawing;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace SlanjeMaila
{
    static class MailFonts
    {
        private const string GLOBALFONTFAMILY = "[FontFamily: Name=]";
        private static string _fontFamily = "Arial";
        public static float FontSize { get; set; } = 12;
        public static FontStyle FontStyle { get; set; }

        public static string FontFamily {
            get
            {
                if(_fontFamily.Contains("[FontFamily: Name="))
                {
                    return _fontFamily.TrimStart(GLOBALFONTFAMILY.ToCharArray()).TrimEnd(']');
                }
                else
                {
                    return _fontFamily;
                }
            }
            set
            {
                _fontFamily = value;
            }
        }
        
        public static void MailFont(Font font)
        {
            FontFamily = font.FontFamily.ToString();
            FontSize = float.Parse(font.Size.ToString());
            FontStyle = font.Style;
        }

        public static void MailFont(string fontFamily, float size, FontStyle fontStyle)
        {
            FontFamily = fontFamily;
            FontSize = size;
            FontStyle = fontStyle;
        }

        public static string Convert(string poruka)
        {
            FontFamily[] tempFontFamilies;
            InstalledFontCollection tempSviInstaliraniFontovi = new InstalledFontCollection();
            tempFontFamilies = tempSviInstaliraniFontovi.Families;

            //svaki put se resetaju html tagovi za poruku za mogucnost slanja vise poruka
            poruka = Regex.Replace(poruka, @"<[^>]*>", string.Empty);

            //promjena fameje fonta
            foreach (var jedanFont in tempFontFamilies)
            {
                if (jedanFont.ToString() == _fontFamily)
                {
                    poruka = "<font face =\"" + FontFamily + "\">" + poruka + "</font>";
                    break;
                }
            }

            //promjena velicine fonta
            poruka = "<span style =\"font-size:" + FontSize + "px\">" + poruka + "</span>";

            //promjena stajla fonta
            switch (FontStyle)
            {
                case FontStyle.Bold:
                    poruka = "<b>" + poruka + "</b>";
                    break;
                case FontStyle.Italic:
                    poruka = "<i>" + poruka + "</i>";
                    break;
                case FontStyle.Strikeout:
                    poruka = "<del>" + poruka + "</del>";
                    break;
                case FontStyle.Underline:
                    poruka = "<u>" + poruka + "</u>";
                    break;
            }
            return poruka;
        }
    }
}
