using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class TextWriter : Subject
    {

        private string State;
        
        public string state
        {
            get => State;
            set
            {
                State = value;
                Notify(State);
            }
        }

        public TextWriter()
        {
            State = String.Empty;
        }
       
    }
}