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

            writer.Subscribe(wordSearcher);

            writer.Subscribe(symbolCounter);


            Console.WriteLine("Type");
            do
            {
                key = Console.ReadKey();
                writer.state = writer.state + key.KeyChar;

            } while (key.Key != ConsoleKey.Enter);
        }



    }
}
