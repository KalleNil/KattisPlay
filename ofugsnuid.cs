using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            List<int> inputOrder = new List<int>();

            for (int i = 0; i<x; i++)
            {
                inputOrder.Add(Convert.ToInt32(Console.ReadLine()));
            }

            inputOrder.Reverse();

            for (int i = 0; i<x; i++)
            {
                Console.WriteLine(inputOrder[i]);
            }
        }
    }
}
