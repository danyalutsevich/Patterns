using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    interface IComponent
    {
        float GetPrice();
        string GetDescription();
    }
}
