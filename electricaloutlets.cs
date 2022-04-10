using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int result = 0;
                for (int j = 1; j < Convert.ToInt32(input[0]); j++)
                {
                    result += Convert.ToInt32(input[j]) -1;
                }
                Console.WriteLine(result + Convert.ToInt32(input[input.Length-1]));
            }
        }
    }
}