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
            string ranks = "A23456789TJQK";

            string[] input = Console.ReadLine().Split(" ");

            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentCard = input[i];
                int currentCardRank = Convert.ToInt32(currentCard[0]);

                int tempResult = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    string tempCard = input[j];
                    int tempCardRank = Convert.ToInt32(tempCard[0]);
                    if (currentCardRank == tempCardRank) tempResult++;
                }

                if (tempResult > result) result = tempResult;
            }

            Console.WriteLine(result);

        }
    }
}