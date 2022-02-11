using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int leftSide = Convert.ToInt32(input[0]);
            int rightSide = Convert.ToInt32(input[1]);

            if(leftSide == rightSide && leftSide == 0)
            {
                Console.WriteLine("Not a moose");
            }else if(leftSide > rightSide)
            {
                Console.WriteLine($"Odd {leftSide*2}");
            }else if (leftSide < rightSide)
            {
                Console.WriteLine($"Odd {rightSide*2}");
            }else if(leftSide == rightSide)
            {
                Console.WriteLine($"Even {leftSide*2}");
            }

        }
    }
}
