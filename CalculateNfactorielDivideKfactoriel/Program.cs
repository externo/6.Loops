using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateNfactorielDivideKfactoriel
{
    class Program
    {
        public static int Factoriel(int n)
        {
            int factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }

        static void Main()
        {
            Console.WriteLine(@"Program that calculates n! / k! for given n and k (1 < k < n < 100).");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write k = ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("n! / k! = {0}", Program.Factoriel(n)/Program.Factoriel(k));
        }
    }
}
