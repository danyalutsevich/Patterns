using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    abstract class Subject
    {

        private List<Observer> observers = new List<Observer>();
        private object state;

        public void Subscribe(Observer observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        virtual public void Notify(object arg = null)
        {
            if(arg is null)
            {
                arg = state;
            }

            foreach (Observer observer in observers)
            {
                observer.Update(arg);
            }
        }
        
    }
}
