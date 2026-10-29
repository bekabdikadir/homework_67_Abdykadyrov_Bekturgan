using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication3.Services
{
    public class PasswordHasher
    {
        public byte[] Md5HashPassword(string password)
        {
            return MD5.HashData(Encoding.UTF8.GetBytes(password));
        }
        public string ToHex(byte[] bytes)
        {
            return Convert.ToHexStringLower(bytes);
        }
    }
}
