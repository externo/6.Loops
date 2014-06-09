using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that checks n numbers whether the product of the odd elements is equal to the product of the even elements.");
            Console.WriteLine("Write numbers in one line, separated only by space: ");
            string singleLine = Console.ReadLine();
            string[] numbersInLine = singleLine.Split(' ');
            double[] numbers = Array.ConvertAll<string, double>(numbersInLine, double.Parse);
            double oddProduct = 1;
            double evenProduct = 1;
            for (int i = 0; i < numbers.Length; i+=2 )
            {
                oddProduct *= numbers[i];
            }
            for (int i = 1; i < numbers.Length; i += 2)
            {
                evenProduct *= numbers[i];
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("Yes! The product is: {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("No! The product of odds is {0} and the product of evens is {1}.", oddProduct, evenProduct);
            }
        }
    }
}
