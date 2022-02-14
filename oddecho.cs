using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            int rows = Convert.ToInt32(Console.ReadLine());
            List<string> input = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                input.Add(Console.ReadLine());
            }
            for (int i = 0; i < input.Count; i++)
            {
                if(input.IndexOf(input[i])%2 == 0)
                {
                    Console.WriteLine(input[i]);
                }
            }
        } 
    }
}
