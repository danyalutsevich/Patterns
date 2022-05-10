using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class DigitCounter : IObserver
    {
        public void Update(object text)
        {
            if (text is string str)
            {
                int digitCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                    {
                        digitCount++;
                    }
                }
                Console.WriteLine($"Digit count: {digitCount}");
            }
            else
            {
                throw new ArgumentException("Invalid argument type");
            }

        }
    }
}
