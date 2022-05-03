using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    class Strategy
    {

        private static List<double> data = new List<double>() { 1, 2, 3, 4, 5, 0 };

        private static MeanCalculator MeanCalculator = new MeanCalculator();

        static Strategy()
        {
            MeanCalculator.Strategies.Add(new MeanArithmetics());
            MeanCalculator.Strategies.Add(new MeanHarmonic());
            MeanCalculator.Strategies.Add(new MeanGeometric());
        }

        public static void Compute()
        {

            Console.WriteLine("Mean:");

            foreach (var mean in MeanCalculator.GetAll(data))
            {

                Console.WriteLine(mean);

            }

            Console.WriteLine("Greatest Mean: {0}", MeanCalculator.GetGreatest(data));

        }

        public static void ComputeDetails()
        {

            for (int i = 0; i < MeanCalculator.Strategies.Count; i++)
            {
                Console.WriteLine($"{i + 1} {MeanCalculator.Strategies[i].GetType().Name}");
            }

            Console.WriteLine("Choose strategy:");
            int strategy = int.Parse(Console.ReadLine());
            data.Clear();

            Console.WriteLine("Enter data:");

            ConsoleKeyInfo key;

            var sb = new StringBuilder();

            do
            {
                key = Console.ReadKey(true);
                
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                {
                    Console.Write(key.KeyChar);
                    sb.Append(double.Parse(key.KeyChar.ToString()));
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    data.Add(double.Parse(sb.ToString()));
                    Console.WriteLine();
                    sb.Clear();
                }

            } while (key.Key != ConsoleKey.Escape);
            Console.WriteLine();
            Console.WriteLine("Mean:");

            foreach (var mean in MeanCalculator.GetAll(data))
            {

                Console.WriteLine(mean);

            }

            Console.WriteLine($"Greatest Mean: {MeanCalculator.GetGreatest(data)}");

        }

    }
}
