using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateFactoriels
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

        static void Main(string[] args)
        {
            Console.WriteLine(@"Program that, for a given two integer numbers n and x, calculates the sum 
S = 1 + 1!/x + 2!/x2 + … + n!/xn.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write x = ");
            double x = int.Parse(Console.ReadLine());
            double S = 1;
            for (int i = 1; i <= n; i++)
            {
                S = S + Program.Factoriel(i) / Math.Pow(x, i);
            }
            Console.WriteLine("Sum S = {0:0.00000}", S);
        }
    }
}
