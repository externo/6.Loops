using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomizeNumbers1_N
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that enters in integer n and prints the numbers 1, 2, …, n in random order.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            
            //make ordered array
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array.SetValue(i+1, i); 
            }
            Console.WriteLine();
            
            //make random array from the ordered array
            Random rand = new Random();
            int[] randomArray = new int[n];
            int j = 0;
            while (j < n)
            {
                int randomValue = array[rand.Next(0,n)];
                if (!randomArray.Contains(randomValue))
                {
                    randomArray.SetValue(randomValue, j);
                    j++;
                }
            }

            //print the random array on the console
            Console.Write("The random array with {0} numbers is: ", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write(randomArray[i] + " ");
            }
        }
    }
}
