using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrailingZeroesInNfactoriel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that calculates with how many zeroes the factorial of a given number n has at its end.");
            Console.WriteLine("Write n = ");
            ulong n = ulong.Parse(Console.ReadLine());
            double sum = 0;
            int i = 1;
            while (n/Math.Pow(5, i) >= 1)
            {
                sum += Math.Round(n / Math.Pow(5, i), 0);
                i++;
            }
            Console.WriteLine("Zeroes in factoriel of {0} are {1}.", n, sum);
        }
    }
}
