using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    class MeanGeometric : IMeanValue
    {
        public double GetMeanValue(List<double> values)
        {

            double ret=1;

            foreach (var v in values)
            {
                ret *= v;
            }
            
            return Math.Pow(ret, 1.0 / values.Count);

        }
    }
}
