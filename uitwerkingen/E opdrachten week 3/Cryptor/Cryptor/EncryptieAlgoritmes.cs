using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College5.Cryptor
{
    static class EncryptieAlgoritmes
    {
        public static string SimpleEncrypt(string input)
        {
            string encryptedMessage =  "";
            foreach (char c in input)
            {
                int.TryParse(c.ToString(), out int output);
                encryptedMessage += ((output +7) % 10) .ToString();
            }
            encryptedMessage = encryptedMessage[2].ToString() + encryptedMessage[3] + encryptedMessage[0] + encryptedMessage[1];
            return encryptedMessage;
        }

        public static string SimpleDecrypt(string input)
        {
            string decryptedMessage = "";
            foreach (char c in input)
            {
                int.TryParse(c.ToString(), out int output);
                decryptedMessage += ((output + 3) % 10).ToString();
            }
            decryptedMessage = decryptedMessage[2].ToString() + decryptedMessage[3] + decryptedMessage[0] + decryptedMessage[1];
            return decryptedMessage;
        }
    }
}
