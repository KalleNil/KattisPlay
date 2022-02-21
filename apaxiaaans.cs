using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            char lastChar = input[0];
            result += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if(lastChar == input[i])
                {

                }
                else
                {
                    result += input[i];
                    lastChar = input[i];
                }
            }
            Console.WriteLine(result);
        } 
    }
}
