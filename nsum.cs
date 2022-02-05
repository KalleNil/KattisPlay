using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(" ");
            int sum = 0;
            for(int i = 0; i<numberCount; i++)
            {

                sum += Convert.ToInt32(numbers[i]);
            }
            Console.WriteLine(sum);

           
        }
    }
}
