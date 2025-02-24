using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class ColumnMethod : CryptMethod
    {

        public override void Encrypt()
        {
            if (!(PlainText == null && PlainKey == null))
            {
                this.GetClearKey();
                this.GetClearText();
                int[,] sortedKey = new int[Key.Length, 2];
                for (int i = 0; i < Key.Length; i++)
                {
                    sortedKey[i, 0] = Key[i];
                    sortedKey[i, 1] = i;
                }

                for (int i = 0; i < sortedKey.GetLength(0); i++)
                    for (int i2 = 1; i2 < sortedKey.GetLength(0); i2++)
                        if (sortedKey[i2 - 1, 0] > sortedKey[i2, 0])
                        {
                            int char1 = sortedKey[i2 - 1, 0];
                            int char2 = sortedKey[i2 - 1, 1];

                            sortedKey[i2 - 1, 0] = sortedKey[i2, 0];
                            sortedKey[i2 - 1, 1] = sortedKey[i2, 1];

                            sortedKey[i2, 0] = char1;
                            sortedKey[i2, 1] = char2;
                        }

                char[] encryptedText = new char[0];
                while (Text.Length % Key.Length != 0)
                    Text = new string(Text + "\0");
                for (int i = 0; i < Key.Length; i++)
                {
                    for (int j = 0; j < Text.Length / Key.Length; j++)
                        encryptedText = encryptedText.Append(Text[Key.Length * j + sortedKey[i, 1]]).ToArray();
                }
                Text = new String(encryptedText);
                StringBuilder sb = new StringBuilder("");
                for (int i = 0; i < encryptedText.Length; i++)
                    if (encryptedText[i] != 0)
                        sb.Append(encryptedText[i]);
                Text = sb.ToString();
                this.SetPlainText();
            }
        }

        public override void Decrypt()
        {
            if (!(PlainText == null && PlainKey == null))
            {
                this.GetClearKey();
                this.GetClearText();
                int[,] sortedKey = new int[Key.Length, 2];
                for (int i = 0; i < Key.Length; i++)
                {
                    sortedKey[i, 0] = Key[i];
                    sortedKey[i, 1] = i;
                }
                for (int i = 0; i < sortedKey.GetLength(0); i++)
                    for (int i2 = 1; i2 < sortedKey.GetLength(0); i2++)
                        if (sortedKey[i2 - 1, 0] > sortedKey[i2, 0])
                        {
                            int char1 = sortedKey[i2 - 1, 0];
                            int char2 = sortedKey[i2 - 1, 1];

                            sortedKey[i2 - 1, 0] = sortedKey[i2, 0];
                            sortedKey[i2 - 1, 1] = sortedKey[i2, 1];

                            sortedKey[i2, 0] = char1;
                            sortedKey[i2, 1] = char2;
                        }
                char[] decryptedText = { '\0' };
                if (Text.Length % Key.Length != 0)
                {
                    int leftOver = Text.Length % Key.Length;
                    for (int i = 0, j = 0; i < Key.Length; i++)
                    {
                        for (int k = 0; k < Text.Length / Key.Length; k++)
                            decryptedText = decryptedText.Append(Text[j + k]).ToArray();
                        j += Text.Length / Key.Length;
                        if (sortedKey[i, 1] > leftOver - 1)
                        {
                            decryptedText = decryptedText.Append('\0').ToArray();
                        }
                        else
                        {
                            decryptedText = decryptedText.Append(Text[j]).ToArray();
                            j++;
                        }
                    }
                    decryptedText = decryptedText.Skip(1).ToArray();
                    Text = new string(decryptedText);
                    decryptedText = new char[] { '\0' };
                }
                for (int i = 0; i < Text.Length / Key.Length; i++)
                {
                    for (int j = 0; j < Key.Length; j++)
                    {
                        int index = 0;
                        for (int k = 0; k < Key.Length && index == 0; k++)
                        {
                            if (Key[j] == sortedKey[k, 0])
                                index = k;
                        }
                        decryptedText = decryptedText.Append(Text[index * Text.Length / Key.Length + i]).ToArray();
                    }
                }
                Text = new string(decryptedText.Skip(1).ToArray());
                this.SetPlainText();
            }
        }
    }
}