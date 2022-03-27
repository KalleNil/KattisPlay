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
            string[] input = (Console.ReadLine().Split(" "));

            DateTime x = new DateTime(2009, Convert.ToInt32(input[1]), Convert.ToInt32(input[0]));
            Console.WriteLine(x.DayOfWeek);
        }
    }
}