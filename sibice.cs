using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            int n = Convert.ToInt32(input[0]);
            int h = Convert.ToInt32(input[1]);
            int w = Convert.ToInt32(input[2]);

            double box = Math.Sqrt(w * w + h * h);


            for(int i = 0; i< n; i++)
            {

                int matchesLength = Convert.ToInt32(Console.ReadLine());

                if (box >= matchesLength)
                {
                    Console.WriteLine("DA");
                }
                else
                {
                    Console.WriteLine("NE");
                }

            } 


          
        }
    }
}
