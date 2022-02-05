using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            
            
            for(int i = 0; i<testCases; i++)
            {
                int numberOfWorkTrips = Convert.ToInt32(Console.ReadLine());
                List<string> olikaLänder = new List<string>(); 
                for (int j = 0; j<numberOfWorkTrips; j++)
                {
                    string land = Console.ReadLine();
                    if (!olikaLänder.Contains(land))
                    {
                        olikaLänder.Add(land);
                    }
                }
                Console.WriteLine(olikaLänder.Count);
            }
           
        }
    }
}
