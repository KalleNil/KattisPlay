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
            int megabytesInPlan = Convert.ToInt32(Console.ReadLine());
            int months = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < months; i++)
            {
                int used = Convert.ToInt32(Console.ReadLine());

                result += megabytesInPlan - used;
            }
            Console.WriteLine(result + megabytesInPlan);
        }
    }
}