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
            int casesInput = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < casesInput; i++)
            {
                string result = "";
                string[] input = Console.ReadLine().ToLower().Split(" ");
                for (int j = 2; j < input.Length; j++)
                {
                    
                    if(input[0] == "simon" && input[1] == "says")
                    {
                        result += input[j] + " ";
                    }
                    
                    
                }
                if (result != "")
                {
                    Console.WriteLine(result);
                    result = "";
                }
            }
        }
    }
}

