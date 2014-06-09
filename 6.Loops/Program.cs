using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers1toN
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that enters from the console a positive integer n and prints all the numbers from 1 to n, 
on a single line, separated by a space.");
            Console.WriteLine("Write positive integer = ");
            int positiveInteger = int.Parse(Console.ReadLine());
            for (int i = 1; i <= positiveInteger; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
