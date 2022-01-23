using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
   
            int[] sets = { 1, 1, 2, 2, 2, 8 };

            string[] inputSet = Console.ReadLine().Split(" ");

            List<int> inputSetList = new List<int>();
            for (int x = 0; x<inputSet.Length; x++)
            {
                inputSetList.Add(Convert.ToInt32(inputSet[x]));
            }

            List<int> piecesNeeded = new List<int>();


            for (int x = 0; x < 6; x++)
            {
                if (inputSetList[x] == 0)
                {
                    piecesNeeded.Add(sets[x]);
                }
                else if(inputSetList[x] > sets[x])
                {
                    piecesNeeded.Add(sets[x] - inputSetList[x]);
                }else if (inputSetList[x] < sets[x])
                {
                    piecesNeeded.Add(sets[x] - inputSetList[x]);
                }
                else
                {
                    piecesNeeded.Add(0);
                }

            }

            Console.WriteLine($"{piecesNeeded[0]} {piecesNeeded[1]} {piecesNeeded[2]} {piecesNeeded[3]} {piecesNeeded[4]} {piecesNeeded[5]}");

        }
    }
}
