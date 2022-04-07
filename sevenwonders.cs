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
            string input = Console.ReadLine();

            char[] scientificCards = { 'T','G','C' };

            int tCount = 0;
            int gCount = 0;
            int cCount = 0;

            double result = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == scientificCards[0]) tCount++;
                else if (input[i] == scientificCards[1]) gCount++;
                else cCount++;
            }

            result += Math.Pow(tCount,2) + Math.Pow(gCount, 2) + Math.Pow(cCount, 2);

            while (tCount > 0 && gCount > 0 && cCount> 0)
            {
                if (tCount > 0 && gCount > 0 && cCount > 0)
                {
                    result += 7;
                    tCount--;
                    gCount--;
                    cCount--;
                }
            }

            Console.WriteLine(result);
        }
    }
}