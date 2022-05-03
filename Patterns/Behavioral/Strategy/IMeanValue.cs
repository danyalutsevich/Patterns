using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    interface IMeanValue
    {
        public double GetMeanValue(List<double> values);
    }
}
