using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int n = Convert.ToInt32(input[2]);
            int x = Convert.ToInt32(input[0]);
            int y = Convert.ToInt32(input[1]);

            int currentNum = 1;

            for (int i = 0; i<n; i++)
            {
                if (currentNum % y == 0 && currentNum % x == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }else if (currentNum%x == 0)
                {
                    Console.WriteLine("Fizz");
                }else if (currentNum%y == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(currentNum);
                }


                    currentNum += 1;
            }

        }
    }
}
