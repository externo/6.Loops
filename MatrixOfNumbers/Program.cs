using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixOfNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < i+n; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
