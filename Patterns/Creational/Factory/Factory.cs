using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory
{
    class CryptoFactory
    {
        public static IHasher GetInstance(string name)
        {
            name = name.ToUpper();

            switch (name)
            {
                case "MD5":
                    return new MD5Hasher();
                case "SHA1":
                    return new SHA1Hasher();
                case "KUPINA":
                    return new KupinaHasher();
                case "SHA2":
                    return new SHA2Hasher();
                case "HMACMD5":
                    return new HMACMD5Hasher();
                default:
                    throw new Exception($"Invalid hasher name {name}");
            }
        }

        public static void Show()
        {
            try
            {
                Console.WriteLine("Choose hasher: ");
                var name = Console.ReadLine();
                IHasher hasher = CryptoFactory.GetInstance(name);

                Console.WriteLine("Text to hash: ");
                var input = Console.ReadLine();

                Console.WriteLine($"{name} hash for {input}: ");
                Console.WriteLine(hasher.Hash(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }





}
