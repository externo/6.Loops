using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexadecimalToDecimalNumber
{
    class Program
    {
        private static double ParseHexString(string hexNumber)
        {
            hexNumber = hexNumber.Replace("x", string.Empty);
            long result = 0;
            long.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Program that converts a hexadecimal integer number to its decimal form.");
            Console.WriteLine("Write hexadecimal number = ");
            string hex = Console.ReadLine();
            double integer = 0;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                string letter = hex[i].ToString();
                if (letter != "0")
                {
                    double bit = Program.ParseHexString(letter);
                    integer += bit*Math.Pow(16, hex.Length -1 - i);
                }
            }
            Console.WriteLine("Decimal number = " + integer);
        }
    }
}
