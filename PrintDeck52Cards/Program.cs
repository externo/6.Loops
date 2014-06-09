using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintDeck52Cards
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). ");
            char[] colors = { '♣', '♦', '♥', '♠' };
            string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            foreach (string value in values)
            {
                foreach (char color in colors)
                {
                    Console.Write(color+value+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
