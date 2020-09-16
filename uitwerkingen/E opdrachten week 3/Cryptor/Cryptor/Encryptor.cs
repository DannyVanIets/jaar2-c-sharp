using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptor
{
    public delegate string EncryptieAlgoritme(string input);
    public delegate string DecryptieAlgoritme(string input);

    class Encryptor
    {
        private EncryptieAlgoritme EncryptieAlg { get; }
        private DecryptieAlgoritme DecryptieAlg { get; }

        public Encryptor(EncryptieAlgoritme encryptieAlg, DecryptieAlgoritme decryptieAlg)
        {
            EncryptieAlg = encryptieAlg;
            DecryptieAlg = decryptieAlg;
        }

        public string Encrypt(string input)
        {
            if(EncryptieAlg == null)
            {
                Console.WriteLine("Geen encryptie alg.");
                
            }
            else
            {
                return EncryptieAlg(input);
            }

            return input;
        }

        public string Decrypt(string input)
        {
            if (DecryptieAlg == null)
            {
                Console.WriteLine("Geen decryptie alg.");
            }
            else
            {
                return DecryptieAlg(input);
            }
            return input;
        }
    }
}
