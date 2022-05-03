using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    class MeanArithmetics : IMeanValue
    {
        public  double GetMeanValue(List<double> values)
        {
            return values.Average();
        }
        
    }
}
