using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory
{

    class MD5Hasher : IHasher
    {
        public string Hash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (var i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }

    class SHA1Hasher : IHasher
    {
        public string Hash(string input)
        {
            var sb = new System.Text.StringBuilder();

            using (SHA1 hasher = SHA1.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = hasher.ComputeHash(bytes);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
            }

            return sb.ToString();
        }
    }

    class KupinaHasher : IHasher
    {
        public string Hash(string input)
        {
            return "Kupina: " + input;
        }
    }

    class SHA2Hasher : IHasher
    {
        public string Hash(string input)
        {
            var sb = new System.Text.StringBuilder();

            using (SHA256 hasher = SHA256.Create())
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
                byte[] hash = hasher.ComputeHash(bytes);

                foreach (var b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
            }

            return sb.ToString();
        }
    }

    class HMACMD5Hasher : IHasher
    {
        public string Hash(string input)
        {
            var sb = new StringBuilder();

            using (var hmacmd5 = HMACMD5.Create())
            {
                var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                var hashBytes = hmacmd5.ComputeHash(inputBytes);

                for (var i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
            }

            return sb.ToString();
        }
    }

}
