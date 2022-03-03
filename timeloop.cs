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
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{i+1} Abracadabra");
            }
        }
    }
}

