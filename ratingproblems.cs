using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputRow1 = Console.ReadLine().Split(" ");

            int judgesRated = Convert.ToInt32(inputRow1[1]);

            double alreadySubmited = 0;

            double highest = 0;
            double lowest = 0;



            for(
                int i = 0; i< judgesRated; i++)
            {
                alreadySubmited += Convert.ToDouble(Console.ReadLine());
            }
            for(int i= 0; i<Convert.ToInt32(inputRow1[0]) - Convert.ToInt32(inputRow1[1]); i++)
            {
                highest += 3;
                lowest += -3;
                judgesRated++;
            }
            Console.WriteLine($"{(lowest + alreadySubmited) / judgesRated} {(highest + alreadySubmited) / judgesRated}");
        }
    }
}
