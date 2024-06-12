using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TourAgency
{
    internal static class Tools
    {
        public static string Hasher(string text)
        {
            try
            {
                SHA256 sha256 = SHA256.Create();
                using (sha256)
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
                    return BitConverter.ToString(bytes).Replace("-", "").ToLower();
                }
            }
            catch
            {
                return text;
            }
        }
    }
}
