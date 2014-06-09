using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomNumbersInGivenRange
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers 
            in the range [min...max].");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write min = ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Write max = ");
            int max = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Random number between {0} and {1}: {2}.", min, max, rand.Next(min, max));
            }
        }
    }
}
