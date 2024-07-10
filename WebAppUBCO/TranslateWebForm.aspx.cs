using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppUBCO.Model;

namespace WebAppUBCO
{
    public partial class TranslateWebForm : System.Web.UI.Page
    {
        Translate _Translate = new Translate();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Translate_Click(object sender, EventArgs e)
        {
            _Translate.Text = txtUBCO.Text;

            _Translate.TextTranslate = TranslateText(_Translate.Text);

            lblTranslate.Text = _Translate.TextTranslate;
        }
        private string TranslateText(string text)
        {
            StringBuilder translated = new StringBuilder();
            translated.Append("UBCO ");

            string[] words = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                foreach (var ch in word)
                {
                    if ("aeiou".Contains(char.ToLower(ch)))
                    {
                        translated.Append(ch);
                        translated.Append(ch);
                    }
                    else if (char.IsLetter(ch))
                    {
                        translated.Append(ShiftConsonant(ch));
                    }
                    else
                    {
                        translated.Append(ch);
                    }
                }
                translated.Append(' ');
            }

            String FullText = translated.ToString().TrimEnd() + words.Length;
            //translated.ToString().TrimEnd();
            //translated.Append(words.Length);
            //return translated.ToString().Trim();
            return FullText;
        }

        private char ShiftConsonant(char ch)
        {
            char lowerCh = char.ToLower(ch);
            char nextCh;
            char nextNewCh = '-';

            if (lowerCh == 'z')
                nextCh = 'b';
            else
            {
                //do
                //{
                nextCh = (char)(lowerCh + 1);
                //Console.WriteLine("nextCh: " + nextCh);

                if ("aeiou".Contains(nextCh))
                {
                    nextNewCh = (char)(nextCh + 1);
                }
                else
                {
                    nextNewCh = nextCh;
                }

                //Console.WriteLine("nextNewCh: " + nextNewCh);
                //}
                // while (!"aeiou".Contains(nextCh));
            }

            return char.IsUpper(ch) ? char.ToUpper(nextNewCh) : nextNewCh;
        }

       
    }
}