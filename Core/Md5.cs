using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Core
{
    public static class Md5
    {
        public static string CrieHash(string frase)
        {
            var hash = string.Empty;
            using (MD5 md5Hash = MD5.Create())
            {
                hash = GetMd5Hash(md5Hash, frase);
            }
            return hash;
        }

        public static bool Valide(string frase, string hash)
        {
            var acerto = false;
            using (MD5 md5Hash = MD5.Create())
            {
                acerto = VerifyMd5Hash(md5Hash, frase, hash);
            }
            return acerto;
        }

        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetMd5Hash(MD5 md5Hash, string source)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(source));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
