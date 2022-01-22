using System;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCases = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x<numOfCases; x++)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                int evenOrOdd = input % 2;

                if(evenOrOdd == 0)
                {
                    Console.WriteLine($"{input} is even");
                }
                else
                {
                    Console.WriteLine($"{input} is odd");
                }
               
            }
       
        }
    }
}
