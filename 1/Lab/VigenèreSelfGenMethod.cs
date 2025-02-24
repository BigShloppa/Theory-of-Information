using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class VigenèreSelfGenMethod : CryptMethod
    {
        public override void Encrypt()
        {
            if (!(PlainText == null && PlainKey == null))
            {
                this.GetClearKey();
                this.GetClearText();
                char[] chars = new char[Text.Length];
                if (Key.Length < Text.Length)
                {
                    int j = 0;
                    for (; j < Key.Length; j++)
                        chars[j] = Key[j];
                    for (; j < chars.Length; j++)
                        chars[j] = Text[j - Key.Length];
                    Key = new String(chars);
                    while (Key.Length < Text.Length)
                        Key = new string(Key.Append(Text[Key.Length - 1]).ToArray());
                }
                chars = new char[]{'\0'};
                for (int i = 0; i < Text.Length; i++)
                    if (Text[i] > 'а' - 1 && Text[i] < 'ё' - 1 + 1)
                    {
                        chars = chars.Append((char)((int)Text[i] - (int)'а' + (int)Key[i])).ToArray();
                        if (chars[i + 1] > 'ё' - 1)
                            chars[i + 1] = (char)(chars[i + 1] + 'а' - 'ё' + 1 - 1);
                    }
                    else
                    {
                        chars = chars.Append((char)((int)Text[i] - (int)'А' + (int)Key[i])).ToArray();
                        if (chars[i + 1] > 'Ё' - 1)
                            chars[i + 1] = (char)(chars[i + 1] - 'Ё' + 1 + 'А' - 1);
                    }
                 Text = new String(chars.Skip(1).ToArray());

                this.SetPlainText();
            }
        }

        public override void Decrypt()
        {
            if (!(PlainText == null && PlainKey == null))
            {
                char[] chars;
                this.GetClearKey();
                this.GetClearText();

                chars = new char[] {'\0'};
                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text[i] > 'а' - 1 && Text[i] < 'ё' - 1 + 1)
                    {
                        chars = chars.Append((char)((int)Text[i] + (int)'а' - (int)Key[i])).ToArray();
                        if (chars[i + 1] < 'а')
                            chars[i + 1] = (char)(chars[i + 1] - 'а' + 'ё' - 1 + 1);
                    }
                    else
                    {
                        chars = chars.Append((char)((int)Text[i] + (int)'А'  - (int)Key[i])).ToArray();
                        if (chars[i + 1] < 'А')
                            chars[i + 1] = (char)(chars[i + 1] - 'А' + 'Ё' - 1 + 1);
                    }
                    if(i == Key.Length - 1)
                        Key = new string(Key.Append(chars[i - PlainKey.Length + 2]).ToArray());
                }
                Text = new String(chars.Skip(1).ToArray());

                this.SetPlainText();
            }
        }
    }
}
