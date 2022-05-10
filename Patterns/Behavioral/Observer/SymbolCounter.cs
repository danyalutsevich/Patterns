using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class SymbolCounter : Observer
    {

        public void Update(object state)
        {
            if (state is string str)
            {
                Console.WriteLine($"SymbolCounter: {str.Length}");
            }
            else
            {
                throw new Exception("SymbolCounter: Invalid state");
            }
        }
    }
}
