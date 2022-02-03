using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int unikaVärden = 0;
            List<int> allaNummer = new List<int>();
            for(int i = 0; i<10; i++)
            {
                
                int input = Convert.ToInt32(Console.ReadLine());
                int remainder = input % 42;
                
                if (!allaNummer.Contains(remainder))
                {
                    allaNummer.Add(remainder);
                }
            }
            Console.WriteLine(allaNummer.Count);
            
        }
    }
}
