using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Auth;
using Authmain;
using StructureEncryption;

namespace Auth
{
    class AuthenticationStructure
    {
        public static readonly IDictionary<int, string> AuthInformation = new Dictionary<int, string>()
        {
            {1, StructureEncryption.Encryption.Encrypt("TTY-SPOOFER")},
            {2, StructureEncryption.Encryption.Encrypt("2e5a08698343fee13b91b333e1e1254af8f61a72beb9fc12f2d6e74138b14e55")},
            {3, StructureEncryption.Encryption.Encrypt("0vHqHKVDGt")},
            {4, StructureEncryption.Encryption.Encrypt("1.0")}
        };
    }

    class AuthenticationObject
    {
        public static api AuthInstance = new api(
        name: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[1]),
        ownerid: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[3]),
        secret: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[2]),
        version: StructureDecryption.AuthStructureDecryption.Decrypt(AuthenticationStructure.AuthInformation[4]));
    }

    class AuthenticationInput
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string License { get; set; }
        public static string AccessToken { get; set; }
    }
}