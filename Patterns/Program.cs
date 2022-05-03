using System;

namespace Patterns
{
    internal class Program
    {
        Creational.Singleton singleton = Creational.Singleton.GetInstance();
        
        static void Main(string[] args)
        {
            #region Singleton

            //// private ctor blocks creation
            ////var singleton = new Creational.Singleton

            //// creation 
            //var singleton1 = Creational.Singleton.GetInstance();
            //Console.WriteLine(singleton1.Moment);
            //var singleton2 = Creational.Singleton.GetInstance();
            //Console.WriteLine(singleton1==singleton2);
            #endregion

            #region Strategy
            
            Patterns.Behavioral.Strategy.Strategy.ComputeDetails();

            #endregion
            
        }
    }
}
