using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            double input = Convert.ToDouble(Console.ReadLine());

            double result = Math.Sqrt(input) * 4;

            Console.WriteLine(result);
        } 
    }
}
