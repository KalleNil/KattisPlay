using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-");
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i][0];
            }
            Console.WriteLine(output);
        } 
    }
}
