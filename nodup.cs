using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            bool wordRepeated = false;
            int occurs = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if(input[i] == input[j])
                    {
                        occurs += 1;
                    }
                }

                if (occurs < 2)
                {
                    occurs = 0;
                }
                
            }
            

            if (occurs >= 2)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }



        }
    }
}
