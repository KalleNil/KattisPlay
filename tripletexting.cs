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
            string input = Console.ReadLine();

            int lengthOfFirstWord = input.Length / 3;

            string word1 = "";
            string word2 = "";
            string word3 = "";

            for (int i = 0; i < lengthOfFirstWord; i++)
            {
                word1 += input[i];
                word2 +=  input[i + lengthOfFirstWord];
                word3 += input[i + (lengthOfFirstWord * 2)] ;
            }
            if (word1 == word2) Console.WriteLine(word1);
            else if (word1 == word3) Console.WriteLine(word1);
            else Console.WriteLine(word2);
        }
    }
}