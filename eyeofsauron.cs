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
            string[] input = Console.ReadLine().Split("()");

            if (input[0].Length == input[1].Length) Console.WriteLine("correct");
            else Console.WriteLine("fix");
        }
    }
}