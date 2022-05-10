using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class CapitalCounter : IObserver
    {

        public void Update(object text)
        {
            if (text is string str)
            {
                int capitalCount = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        capitalCount++;
                    }
                }
                Console.WriteLine($"Capital count: {capitalCount}");
            }
            else
            {
                throw new ArgumentException("Invalid argument type");
            }

        }

    }
}
