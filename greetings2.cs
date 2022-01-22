using System;
namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split("e");

            string addingE = "";

            for(int x = 1; x<input.Length; x++)
            {
                addingE += "ee";
            }

            Console.WriteLine($"h{addingE}y");

        }
    }
}
