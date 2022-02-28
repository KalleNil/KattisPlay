using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int playerAPoints = 0;
            int playerBPoints = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'A')
                {
                    //besviken på char typen.. :(
                    playerAPoints += (int)char.GetNumericValue(input[i + 1]);
                }else if(input[i] == 'B')
                {
                    playerBPoints += (int)char.GetNumericValue(input[i + 1]);
                }
            }
            if(playerAPoints> playerBPoints)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("B");
            }
        } 
    }
}
