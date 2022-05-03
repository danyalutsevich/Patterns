using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    class MeanSquare : IMeanValue
    {
        public double GetMeanValue(List<double> values)
        {

            double sum = 0;
            foreach (double value in values)
            {
                sum += value * value;
            }
            
            return Math.Sqrt(sum / values.Count);

        }
    }
}
