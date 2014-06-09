using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersNotDivisibleBy3and7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that enters from the console a positive integer n and prints all the numbers 
from 1 to n not divisible by 3 and 7, on a single line, separated by a space.");
            Console.WriteLine("Write positive integer = ");
            int positiveInteger = int.Parse(Console.ReadLine());
            for (int i = 1; i <= positiveInteger; i++)
            {
                if (i%3 != 0 && i%7 != 0)
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
