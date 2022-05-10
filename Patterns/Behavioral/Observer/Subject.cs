using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    abstract class Subject
    {

        private List<IObserver> observers = new List<IObserver>();
        private object state;

        public void Subscribe(IObserver observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        virtual public void Notify(object arg = null)
        {
            if(arg is null)
            {
                arg = state;
            }

            foreach (IObserver observer in observers)
            {
                observer.Update(arg);
            }
        }
        
    }
}
