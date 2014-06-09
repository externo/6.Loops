using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToHexadecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that converts an integer number to its hexadecimal representation.");
            Console.WriteLine("Write integer number =");
            long integerNumber = long.Parse(Console.ReadLine());
            long newNumber;
            string hex = "";
            while (integerNumber > 0)
            {
                newNumber = integerNumber % 16;
                hex = newNumber.ToString("X") + hex;
                integerNumber = integerNumber / 16;
            }
            Console.WriteLine("The hexadecimal representation is: " + hex);
        }
    }
}
