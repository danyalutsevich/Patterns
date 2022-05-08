using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory
{
    internal class AbstractFactory
    {
        public static void Show()
        {

            ICryptoFactory factory = new AESFactory();

            ICryptoHasher cryptoHasher = factory.GerHasher();
            Console.WriteLine(cryptoHasher.Hash("testing testing one two one two"));

            ICryptoCipher cryptoCipher = factory.GetCipher();
            Console.WriteLine(cryptoCipher.Cipher("testing testing one two one two"));

        }
    }

    interface ICryptoHasher
    {
        public string Hash(string input);
    }

    interface ICryptoCipher
    {
        public string Cipher(string input);
    }

    interface ICryptoDecipher
    {
        public string Decipher(string input);
    }

    interface ICryptoFactory
    {
        ICryptoHasher GerHasher();
        ICryptoCipher GetCipher();
        ICryptoDecipher GetDecipher();
    }

    class DSTUHasher : ICryptoHasher
    {

        public string Hash(string input)
        {
            return "Kupina hash of " + input;
        }

    }

    class DSTUCipher : ICryptoCipher
    {
        public string Cipher(string input)
        {
            return "Kalina cipher of " + input;
        }
    }

    class DSTUDecipher : ICryptoDecipher
    {
        public string Decipher(string input)
        {
            return "Kupina decipher of " + input;
        }
    }

    class DSTUFactory : ICryptoFactory
    {
        public ICryptoHasher GerHasher()
        {
            return new DSTUHasher();
        }

        public ICryptoCipher GetCipher()
        {
            return new DSTUCipher();
        }

        public ICryptoDecipher GetDecipher()
        {
            return new DSTUDecipher();
        }
    }


    class AESHasher : ICryptoHasher
    {
        public string Hash(string input)
        {
            return "SHA hash of " + input;
        }
    }

    class AESCipher : ICryptoCipher
    {
        public string Cipher(string input)
        {
            return "AES cipher of " + input;
        }
    }

    class AESDecipher : ICryptoDecipher
    {
        public string Decipher(string input)
        {
            return "AES decipher of " + input;
        }
    }

    class AESFactory : ICryptoFactory
    {
        public ICryptoHasher GerHasher()
        {
            return new AESHasher();
        }

        public ICryptoCipher GetCipher()
        {
            return new AESCipher();
        }
        public ICryptoDecipher GetDecipher()
        {
            return new AESDecipher();
        }
    }
}
