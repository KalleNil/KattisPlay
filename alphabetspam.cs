using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string storaAlfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lillaAlfabetet = "abcdefghijklmnopqrstuvwxyz";
            double whiteSpaces = 0;
            double lowerCases = 0;
            double upperCases = 0;
            double symbols = 0;

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '_')
                {
                    whiteSpaces++;
                }
                else if (storaAlfabetet.Contains(input[i])){
                    upperCases++;
                }else if (lillaAlfabetet.Contains(input[i]))
                {
                    lowerCases++;
                }
                else
                {
                    symbols++;
                }
            }
            double alla = whiteSpaces + lowerCases + upperCases + symbols;

            Console.WriteLine(whiteSpaces / alla);
            Console.WriteLine(lowerCases/ alla);
            Console.WriteLine(upperCases/ alla);
            Console.WriteLine(symbols / alla );

        } 
    }
}
