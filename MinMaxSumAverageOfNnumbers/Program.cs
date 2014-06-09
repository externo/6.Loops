using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinMaxSumAverageOfNnumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that reads from the console a sequence of n integer numbers and returns the minimal, 
the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                array[i] = element;
            }
            Console.WriteLine("The minimal number is: {0:0.00}.", array.Min());
            Console.WriteLine("The maximum number is: {0:0.00}.", array.Max());
            Console.WriteLine("The sum of all numbers is: {0:0.00}.", array.Sum());
            Console.WriteLine("The average number is: {0:0.00}.", array.Average());
        }
    }
}
