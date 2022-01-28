using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems51_60
{
    public static class XORDecryption
    {
        public static int FindXORDecryption(int keyLength)
        {
            var sumOfOriginalTextCodes = 0;
            var code = SharedCode.InputHelper.ReadCSVInput(
                    path: @"C:\Users\dmerryman\Documents\repos\ProjectEuler\ProjectEuler\Resources\p059_cipher.txt")
                .Select(int.Parse).ToArray();

            var key = Analysis(message: code, keyLength: keyLength);


            var decryptedMessage = Encrypt(message: code, key: key);
            decryptedMessage.Select(char.ConvertFromUtf32).ToArray();
            char[] chars = new char[decryptedMessage.Length];
            for (int i = 0; i < decryptedMessage.Length; i++)
            {
                chars[i] = (char)decryptedMessage[i];
                sumOfOriginalTextCodes += decryptedMessage[i];
            }

            string message = new string(chars);

            return sumOfOriginalTextCodes;
            throw new NotImplementedException();
        }

        private static int[] Encrypt(int[] message, int[] key)
        {
            int[] encryptedMessage = new int[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                encryptedMessage[i] = message[i] ^ key[i % key.Length];
            }

            return encryptedMessage;
        }

        private static int[] Analysis(int[] message, int keyLength)
        {
            // Getting the maximum value in message.
            int maxSize = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] > maxSize)
                {
                    maxSize = message[i];
                }
            }
            // Making an array keyLength by maxSize + 1 size.
            // Since we know the length of the key, we know how many piles to sort the message into.
            int[,] aMessage = new int[keyLength, maxSize + 1];
            int[] key = new int[keyLength];

            for (int i = 0; i < message.Length; i++)
            {
                int j = i % keyLength;
                aMessage[j, message[i]]++;
                if (aMessage[j, message[i]] > aMessage[j, key[j]])
                {
                    key[j] = message[i];
                }
            }

            // The most used character should be a space.
            int spaceAscii = 32;
            for (int i = 0; i < keyLength; i++)
            {
                key[i] = key[i] ^ spaceAscii;
            }

            return key;
        }
    }
}
