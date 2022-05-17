using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Chain
{
    class ChainDemo
    {

        public static void Show()
        {
            Manipulation coffee = new Coffee();
            
            coffee.Next = new Grind();
            coffee.Next.Next = new Steam();
            coffee.Next.Next.Next = new Boiler();
            coffee.Next.Next.Next.Next = new Washing();

            coffee.Execute(1500);

            Console.WriteLine();
            
            Manipulation coffee2 = new Coffee();

            Console.WriteLine("What kind of coffee do you want?(1/2)");

            if (Console.ReadKey(true).Key == ConsoleKey.D1)
            {
                coffee2.SetNext(new Grind()).SetNext(new Steam()).SetNext(new Boiler()).SetNext(new Sugar()).SetNext(new Milk()).SetNext(new Washing());

            }
            else
            {
                coffee2.SetNext(new Coffee()).SetNext(new Coffee());
            }
            Console.WriteLine("Volume: ");
            try
            {
            coffee2.Execute(int.Parse(Console.ReadLine()));
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }

    abstract class Manipulation
    {
        public Manipulation Next { get; set; }

        public Manipulation SetNext(Manipulation next)
        {
            Next = next;
            return Next;
        }

        public abstract void Execute(int volume);
    }
    
    class Grind : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("grinding");
            Next?.Execute(volume);
        }
    }

    class Coffee : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("Adding a coffee");
            Next?.Execute(volume);
        }
    }

    class Milk : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("Adding milk");
            Next?.Execute(volume);
        }
    }

    class Sugar : Manipulation
    {
        public override void Execute(int volume)
        {

            if (volume > 200)
            {
                throw new ArgumentException("We don't have that much sugar");
            }
            
            Console.WriteLine("Adding sugar");
            Next?.Execute(volume);
        }
    }

    class Boiler : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("boiling water");
            Next?.Execute(volume);
        }
    }

    class Steam : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("steaming");
            Next?.Execute(volume);
        }
    }

    class Washing : Manipulation
    {
        public override void Execute(int volume)
        {
            Console.WriteLine("washing");
            Next?.Execute(volume);
        }
    }


}
