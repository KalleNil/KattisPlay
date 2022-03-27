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
            string[] gunnarInput = Console.ReadLine().Split(" ");
            string[] emmaInput = Console.ReadLine().Split(" ");
            int gunnarTotal = 0;
            int emmaTotal = 0;

            for (int i = 0; i < 4; i++)
            {
                gunnarTotal += Convert.ToInt32(gunnarInput[i]);
                emmaTotal += Convert.ToInt32(emmaInput[i]);
            }

            if (gunnarTotal > emmaTotal)
            {
                Console.WriteLine("Gunnar");
            }else if(gunnarTotal < emmaTotal)
            {
                Console.WriteLine("Emma");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}