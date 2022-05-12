using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

            //Patterns.Behavioral.Strategy.Strategy.ComputeDetails();

            #endregion

            #region Decorator

            //Structural.Decorator.Decorator.Show();

            #endregion

            #region Factory

            //Creational.Factory.CryptoFactory.Show();

            #endregion

            #region Factory Method

            //Creational.Factory.FactoryMethod.Show();

            #endregion

            #region AbstractFactory

            //Creational.Factory.AbstractFactory.Show();

            #endregion

            #region Observer

            //Patterns.Behavioral.Observer.ObserverDemo.Show();

            #endregion

            #region Builder

            //Patterns.Creational.Builder.BuilderDemo.Show();

            #endregion

            #region Bridge

            Patterns.Structural.Proxy.ProxyDemo.Show();

            #endregion

        }



        // creates list of ingredients that can be added to coffee
        private static List<string> WhatYouCanAddToCoffee()
        {
            List<string> ingredients = new List<string>();

            using (var sr = new StreamReader(@"C:\Users\luche\Desktop\Ingredients.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ingredients.Add(line);
                }
            }

            return ingredients;
        }

        // generates classes and whites them to file
        private static void DecoratorGenerator(List<string> ingedients)
        {
            Random random = new Random();

            var decorators = new System.Text.StringBuilder();
            var classes = new System.Text.StringBuilder();

            foreach (var i in ingedients)
            {
                var name = i.Replace(" ", "");
                name = name.Replace("-", "");
                name = name.Replace(".", "");
                name = name.Replace("(", "");
                name = name.Replace(")", "");



                decorators.AppendLine(
                    $"class {name}Decorator : IDecorator\n" +
                    "{\n" +
                    $"public {name}Decorator(IComponent wrappie) : base(wrappie)\n" +
                    "{\n" +
                        $"IComponent component = new {name}();\n" +
                        "description = component.GetDescription();\n" +
                        "price = component.GetPrice();\n" +
                    "}\n" +
                "}");

                classes.AppendLine(
                    $"class {name} : IComponent\n" +
                    "{\n" +
                        "public string Description;\n" +
                        "public float Price;\n" +

                        $"public {name}()\n" +
                        "{\n" +
                        $"Description = \"{name}\";\n" +
                        $"Price = {random.Next(21)};\n" +
                        "}\n" +

                        "public string GetDescription() => Description;\n" +
                        "public float GetPrice() => Price;\n" +

                    "}\n");
            }


            using (var sw = new StreamWriter("DecoratorsGenerated.cs"))
            {
                sw.WriteLine(decorators.ToString());
            }

            using (var sw = new StreamWriter("ClassesGenerated.cs"))
            {
                sw.WriteLine(classes.ToString());
            }
        }

        private static void Decor(List<string> ingedients)
        {
            foreach (var i in ingedients)
            {
                var name = i.Replace(" ", "");
                name = name.Replace("-", "");
                name = name.Replace(".", "");
                name = name.Replace("(", "");
                name = name.Replace(")", "");

                Console.WriteLine($"product = new {name}Decorator(product);");
            }
        }

    }
}
