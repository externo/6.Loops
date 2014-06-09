using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
holding the numbers from 1 to n*n in the form of square spiral.");
            Console.WriteLine("Write n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int number = 1;
            int rowIndexMin = 0;
            int rowIndexMax = n - 1;
            int columnIndexMin = 0;
            int columnIndexMax = n - 1;

            while (number <= n * n)
            {
                //write to the right
                for (int i = columnIndexMin; i <= columnIndexMax; i++)
                {
                    matrix[rowIndexMin, i] = number;
                    number++;
                }
                rowIndexMin++;

                //write down
                for (int i = rowIndexMin; i <= rowIndexMax; i++)
                {
                    matrix[i, columnIndexMax] = number;
                    number++;
                }
                columnIndexMax--;

                //write to the left
                for (int i = columnIndexMax; i >= columnIndexMin; i--)
                {
                    matrix[rowIndexMax, i] = number;
                    number++;
                }
                rowIndexMax--;

                //write up
                for (int i = rowIndexMax; i >= rowIndexMin; i--)
                {
                    matrix[i, columnIndexMin] = number;
                    number++;
                }
                columnIndexMin++;
            }

            //print the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
