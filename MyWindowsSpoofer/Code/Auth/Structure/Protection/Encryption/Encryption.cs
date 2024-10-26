using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StructureEncryption
{
    internal class Encryption
    {
        public static readonly byte[] key = Key.GenerateKey_Rng.GenerateKey();

        public static string Encrypt(string plainText)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV();
                ICryptoTransform encryptor = aesAlg.CreateEncryptor();
                byte[] encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, plainText.Length);
                byte[] ivPlusCipher = new byte[aesAlg.IV.Length + encrypted.Length];
                Array.Copy(aesAlg.IV, 0, ivPlusCipher, 0, aesAlg.IV.Length);
                Array.Copy(encrypted, 0, ivPlusCipher, aesAlg.IV.Length, encrypted.Length);
                return Convert.ToBase64String(ivPlusCipher);
            }
        }
    }
}