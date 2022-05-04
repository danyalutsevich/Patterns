using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Decorator
{
    abstract class IDecorator : IComponent
    {
        protected IComponent wrappie;

        protected float price;
        protected String description;

        public IDecorator(IComponent wrappie)
        {
            this.wrappie = wrappie;
        }

        public string GetDescription()
        {
            if (wrappie is not null)
            {
                return wrappie.GetDescription() + " " + description;
            }
            else
            {
                return description;
            }
        }

        public float GetPrice()
        {
            if (wrappie is not null)
            {
                return price + wrappie.GetPrice();
            }
            else
            {
                return price;
            }
        }

        public override string ToString()
        {
            return GetDescription() + " " + GetPrice();
        }
    }
}
