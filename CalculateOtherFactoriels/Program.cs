using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateOtherFactoriels
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100).");
            Console.WriteLine("Write n = ");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Write k = ");
            ulong k = ulong.Parse(Console.ReadLine());
            ulong variationNK = 1;
            ulong factorielNK = 1;
            if (k >= n / 2)
            {
                for (ulong i = k + 1; i <= n; i++)
                {
                    variationNK *= i;
                }
                for (ulong i = 1; i <= n - k; i++)
                {
                    factorielNK *= i;
                }
            }
            else
            {
                for (ulong i = n - k + 1; i <= n; i++)
                {
                    variationNK *= i;
                }
                for (ulong i = 1; i <= k; i++)
                {
                    factorielNK *= i;
                }
            }
            Console.WriteLine("n! / (k! * (n-k)!) = {0}", (variationNK/factorielNK));
        }
    }
}
