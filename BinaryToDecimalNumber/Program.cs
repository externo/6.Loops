using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that converts a binary integer number to its decimal form. The input is entered as string.");
            Console.WriteLine("Write binary integer = ");
            string binary = Console.ReadLine();
            double integer = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                double bit = double.Parse(binary[i].ToString());
                if (bit == 1)
                {
                    integer += Math.Pow(2, binary.Length - 1 - i);
                }
            }
            Console.WriteLine("Decimal number ="+integer);
        }
    }
}
