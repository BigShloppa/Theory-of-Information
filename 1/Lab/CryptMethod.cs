using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    abstract internal class CryptMethod
    {
        protected string? PlainText;

        protected string? Text;

        protected string? PlainKey;

        protected string? Key;

        public void ReadText(string text) { PlainText = new String(text); }

        public string WriteText() { return new string(PlainText); }

        public void ReadKey(string key) { PlainKey = (new StringBuilder(key)).ToString(); }

        protected void GetClearKey()
        {
            char[] clearKey = new char[0];
            for (int i = 0; i < PlainKey.Length; i++)
            {
                if ((PlainKey[i] > 'а' - 1 && PlainKey[i] < 'ё' + 1) || (PlainKey[i] > 'А' - 1 && PlainKey[i] < 'Ё' + 1))
                    clearKey = clearKey.Append(PlainKey[i]).ToArray();
                if (clearKey[clearKey.Length - 1] == 'Ё' || clearKey[clearKey.Length - 1] == 'ё')
                    clearKey[clearKey.Length - 1] = (char)(clearKey[clearKey.Length - 1] - 1);
            }
            Key = new String(clearKey);
        }

        protected void GetClearText()
        {
            char[] clearText = new char[0];
            for (int i = 0; i < PlainText.Length; i++)
            {
                if ((PlainText[i] > 'а' - 1 && PlainText[i] < 'ё' + 1) || (PlainText[i] > 'А' - 1 && PlainText[i] < 'Ё' + 1))
                {
                    clearText = clearText.Append(PlainText[i]).ToArray();
                    if (clearText[clearText.Length - 1] == 'Ё' || clearText[clearText.Length - 1] == 'ё')
                        clearText[clearText.Length - 1] = (char)(clearText[clearText.Length - 1] - 1);
                    StringBuilder sb = new StringBuilder(PlainText);
                    sb[i] = 'Ч';
                    PlainText = sb.ToString();
                }
            }
            Text = new string(clearText);
        }

        protected void SetPlainText()
        {
            StringBuilder sb = new StringBuilder(PlainText);
            int j = 0;
            for (int i = 0; i < sb.Length; i++)
                if (sb[i] == 'Ч')
                {
                    sb[i] = Text[j];
                    if (sb[i] == 'ё' - 1 || sb[i] == 'Ё' - 1)
                        sb[i] =(char)(sb[i] + 1);
                    j++;
                }
            PlainText = sb.ToString();
        }
        public abstract void Encrypt();

        public abstract void Decrypt();
    }
}
