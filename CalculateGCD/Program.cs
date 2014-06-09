using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateGCD
{
    class Program
    {
        static int GCD(int a, int b)
        {
            int Remainder;
            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }
            return a;
        }

        static void Main()
        {
            Console.WriteLine(@"Program that calculates the greatest common divisor (GCD) of given two integers a and b. ");
            Console.Write("Write a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Write b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The Greatest Common Divisor of {0} and {1} is {2}", a, b, GCD(a, b));
        }
    }
}
