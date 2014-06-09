using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinaryNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that converts an integer number to its binary representation.");
            Console.WriteLine("Write integer number =");
            long integerNumber = long.Parse(Console.ReadLine());
            long newNumber;
            string binary = "";
            while (integerNumber > 0)
            {
                newNumber = integerNumber % 2;
                binary = newNumber.ToString() + binary;
                integerNumber = integerNumber / 2;
            }
            Console.WriteLine("The binary is: " + binary);
        }
    }
}
