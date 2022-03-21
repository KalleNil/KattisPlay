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
            int inputCases = Convert.ToInt32(Console.ReadLine());

            int volume = 7;

            for (int i = 0; i < inputCases; i++)
            {
                string input = Console.ReadLine();

                if(input == "Skru op!" && volume<10)
                {
                    volume++;
                }else if (input == "Skru ned!" && volume>0)
                {
                    volume--;
                }
            }
            Console.WriteLine(volume);

        }
    }
}

