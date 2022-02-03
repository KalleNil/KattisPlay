using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(input, 2);

            char[] binaryToArray = binary.ToCharArray();
            Array.Reverse(binaryToArray);
            string arrayToString = new string(binaryToArray);
            int reversedBinary = Convert.ToInt32(arrayToString, 2);

            Console.WriteLine(reversedBinary);
        }
       
    }
}
