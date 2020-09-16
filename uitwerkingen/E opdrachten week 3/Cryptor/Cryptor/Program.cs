using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using College5.Cryptor;
using static College5.Cryptor.EncryptieAlgoritmes;

namespace Cryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De encryptor is gestart. Type een cijfer van vier getallen:\n");
            String input = Console.ReadLine();

            Encryptor enc = new Encryptor(SimpleEncrypt, SimpleDecrypt);
            string encryptedString = enc.Encrypt(input);
            string decryptedString = enc.Decrypt(encryptedString);


            Console.WriteLine("encrypted message = {0} \n", encryptedString);

            Console.WriteLine("decrypted message = {0} \n", decryptedString);

        }
    }
}
