using System;
using System.Collections.Generic;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            string input1 = input[0];
            string input2 = input[1];

            string number1 = "";
            string number2 = "";
            for(int i = 2; i>-1; i--)
            {
                number1 += input1[i];
                number2 += input2[i];
            }

            int number1ToInt = Convert.ToInt32(number1);
            int number2Toint = Convert.ToInt32(number2);

            if (number1ToInt > number2Toint)
            {
                Console.WriteLine(number1ToInt);
            }
            else
            {
                Console.WriteLine(number2Toint);
            } 
        }
       
    }
}
