using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Lab
{
    internal class StreamEncryptionMethod
    {
        public LFSR? register;

        public byte[] key;

        public byte[]? data;

        public void readFile(string filePath)
        {

            List<byte> bitList = new List<byte>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                int b;
                while ((b = fs.ReadByte()) != -1)
                {
                    for (int i = 7; i >= 0; i--) 
                    {
                        byte bit = (byte)((b >> i) & 1);
                        bitList.Add(bit);
                    }
                }
            }

            data = bitList.ToArray();
        }

        public void writeFile(string filePath)
        {
            if (data == null || data.Length == 0)
                throw new InvalidOperationException("Нет данных для записи.");

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                int bitCount = 0;
                byte currentByte = 0;

                for (int i = 0; i < data.Length; i++)
                {
                    currentByte = (byte)((currentByte << 1) | (data[i] & 1)); 
                    bitCount++;

                    if (bitCount == 8)
                    {
                        fs.WriteByte(currentByte);
                        bitCount = 0;
                        currentByte = 0;
                    }
                }

                if (bitCount > 0)
                {
                    currentByte = (byte)(currentByte << (8 - bitCount));
                    fs.WriteByte(currentByte);
                }
            }
        }

        public string getFirstBytes(byte[] dataSet)
        {
            if (dataSet == null)
                return "";
            char[] charList = new char[15 * 8];
            for (int i = 0; i < charList.Length; i++)
                charList[i] = dataSet[i] == 0 ? '0' : '1';
            return new string(charList);
        }

        public string getLastBytes(byte[] dataSet)
        {
            if (dataSet == null)
                return "";
            char[] charList = new char[15 * 8];
            for (int i = 0; i < charList.Length; i++)
                charList[i] = dataSet[dataSet.Length - 15 * 8 + i] == 0 ? '0' : '1';
            return new string(charList);
        }

        public void generateKey() {
            key = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
                key[i] = register.shift();
        }

        public void encrypt() { 
            for(int i = 0; i < data.Length; i++)
                data[i] ^= key[i];
        }

        public void decrypt()
        {
            for (int i = 0; i < data.Length; i++)
                data[i] ^= key[i];
        }
    }
}
