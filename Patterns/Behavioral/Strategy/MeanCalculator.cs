using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    class MeanCalculator
    {
        public List<IMeanValue> Strategies;

        public MeanCalculator()
        {
            Strategies = new List<IMeanValue>();
        }

        public double GetGreatest(List<double> list)
        {
            List<double> ret = new List<double>();
            double max;
            
            foreach (var strategy in Strategies)
            {
                ret.Add(strategy.GetMeanValue(list));
            }

            return ret.Max();
        }

        public List<double> GetAll(List<double> list)
        {
            List<double> ret = new List<double>();

            foreach (IMeanValue strategy in Strategies)
            {
                ret.Add(strategy.GetMeanValue(list));
            }
            return ret;
        }
        
    }
}
