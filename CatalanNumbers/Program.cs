using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program to calculate the nth Catalan number by given n (1 < n < 100).");
            Console.WriteLine("Write n = ");
            ulong n = ulong.Parse(Console.ReadLine());
            ulong numerator = 1;
            ulong denumerator = 1;
            for (ulong i = n + 2; i <= 2*n; i++)
            {
                numerator *= i;
            }
            for (ulong i = 1; i <= n; i++)
            {
                denumerator *= i;
            }
            Console.WriteLine("The nth Catalan number is {0}", numerator/denumerator);
        }
    }
}
