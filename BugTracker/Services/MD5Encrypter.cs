using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    static class MD5Encrypter
    {
        public static  String encryptString(String rawString)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(rawString);

            byte[] hash = md5.ComputeHash(inputBytes);

            string hex = BitConverter.ToString(hash);

            return hex.Replace("-", "");
        }
    }
}
