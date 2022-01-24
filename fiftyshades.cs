using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int roseOrPink = 0;
            int inputCases = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i< inputCases; i++)
            {
                string samples = Console.ReadLine().ToLower();

                if (samples.Contains("rose") || samples.Contains("pink"))
                {
                    roseOrPink++;
                }

            }
            
            if (roseOrPink > 0)
            {
                Console.WriteLine(roseOrPink);

            }
            else
            {
                Console.WriteLine("I must watch Star Wars with my daughter");
            }
        }
    }
}
