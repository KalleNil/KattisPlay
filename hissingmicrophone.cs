using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            char lastChar = 'P';

            bool hissOrNot = false;

            for(int i = 0; i<input.Length; i++)
            {
                

                char currentChar = input[i];

                if (lastChar == 's' && currentChar == 's')
                {
                    hissOrNot = true;
                }
                lastChar = input[i];
            }
            if (hissOrNot)
            {
                Console.WriteLine("hiss");
            }
            else
            {
                Console.WriteLine("no hiss");
            }
        }
    }
}
