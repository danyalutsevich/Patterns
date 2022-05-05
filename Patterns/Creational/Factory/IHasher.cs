using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational.Factory
{
    interface IHasher
    {
        string Hash(string input);
    }
}
