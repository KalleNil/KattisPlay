using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int a = Convert.ToInt32(input[0]);
            int b = Convert.ToInt32(input[1]);

            if (a < b)
            {
                Console.WriteLine($"{a} {b}");
            }
            else
            {
                Console.WriteLine($"{b} {a}");
            }
        }
    }
}
