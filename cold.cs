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
            int casesInput = Convert.ToInt32(Console.ReadLine());
            string[] temperatures = Console.ReadLine().Split();
            int result = 0;
            for (int i = 0; i < casesInput; i++)
            {
                if (Convert.ToInt32(temperatures[i]) <0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}

