using Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StructureDecryption
{
    internal class AuthStructureDecryption
    {
        public static string Decrypt(string cipherText)
        {
            byte[] ivPlusCipher = Convert.FromBase64String(cipherText);
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = StructureEncryption.Encryption.key;
                var iv = new byte[16];
                Array.Copy(ivPlusCipher, 0, iv, 0, iv.Length);
                aesAlg.IV = iv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor();
                byte[] decrypted = decryptor.TransformFinalBlock(ivPlusCipher, iv.Length, ivPlusCipher.Length - iv.Length);
                return Encoding.UTF8.GetString(decrypted);
            }
        }
    }
}