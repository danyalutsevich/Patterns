using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Creational
{
    class Singleton
    {
        public DateTime Moment => DateTime.Now;

        private static Singleton instance;
        
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        private Singleton()
        {
        }

    }
}
