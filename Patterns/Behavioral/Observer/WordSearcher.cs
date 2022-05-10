using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    class WordSearcher : Observer
    {

        List<string> WordsToSearch;

        public WordSearcher()
        {
            WordsToSearch = new List<string>() { "Max" };
        }

        public void Update(object text)
        {
            if (text is string str)
            {

                foreach (var word in WordsToSearch)
                {
                    int foundWords = Regex.Matches(str, $"^{word}$").Count;
                    if (foundWords > 0)
                    {
                        Console.WriteLine($"Found word: {word} {foundWords} times");
                    }
                }
            }
            else
            {
                throw new ArgumentException("Invalid argument type");
            }

        }
    }

}
