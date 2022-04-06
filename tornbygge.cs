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
            int bricks = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");

            int result = 1;

            for (int i = 0; i < bricks-1; i++)
            {
                if(Convert.ToInt32(input[i]) < Convert.ToInt32(input[i + 1]))
                {
                    result++;

                }
            }
            Console.WriteLine(result);
        }
    }
}