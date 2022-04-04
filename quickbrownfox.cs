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
            int cases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cases; i++)
            {
                string aToZ = "abcdefghijklmnopqrstuvwxyz";
                string result = "";
                string input = Console.ReadLine().ToLower();
                for (int j = 0; j < input.Length; j++)
                {
                    for (int k = 0; k < aToZ.Length; k++)
                    {
                        if (input[j] == aToZ[k]) aToZ = aToZ.Remove(k,1);
                    }
                }
                if (aToZ.Length > 0) Console.WriteLine($"missing {aToZ}");
                else Console.WriteLine("pangram");
            }
        }
    }
}