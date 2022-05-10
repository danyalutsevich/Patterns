using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    internal class ObserverDemo
    {
        public static void Show()
        {

            ConsoleKeyInfo key;

            TextWriter writer = new TextWriter();
            SymbolCounter symbolCounter = new SymbolCounter();
            WordSearcher wordSearcher = new WordSearcher();
            CapitalCounter capitalCounter = new CapitalCounter();
            DigitCounter digitCounter = new DigitCounter();
            
            writer.Subscribe(wordSearcher);
            writer.Subscribe(symbolCounter);
            writer.Subscribe(capitalCounter);
            writer.Subscribe(digitCounter);


            Console.WriteLine();
            Console.WriteLine("Type");
            do
            {
                key = Console.ReadKey(true);
                Console.Clear();
                writer.state = writer.state + key.KeyChar;
                Console.WriteLine(writer.state);

            } while (key.Key != ConsoleKey.Enter);
        }



    }
}
