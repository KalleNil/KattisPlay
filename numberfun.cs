using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<testCases; i++)
            {
                string[] inputTests = Console.ReadLine().Split(" ");

                double a = Convert.ToDouble(inputTests[0]);
                double b = Convert.ToDouble(inputTests[1]);
                int c = Convert.ToInt32(inputTests[2]);

                if(a + b == c || a / b == c|| a - b == c|| a * b == c || b / a == c || b - a == c)
                {
                    Console.WriteLine("Possible");
                }
                else
                {
                    Console.WriteLine("Impossible");
                }
                

            }
        }
    }
}
