using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int pieces = Convert.ToInt32(input[1]);
            int people = Convert.ToInt32(input[0]);

            string pieceOrPieces= "";

            if(pieces - people == 1 || people - pieces == 1)
            {
                pieceOrPieces = "piece";
            }
            else
            {
                pieceOrPieces = "pieces";
            }

            if (pieces >= people)
            {
                Console.WriteLine($"Dr. Chaz will have {pieces - people} {pieceOrPieces} of chicken left over!");
            }
            else
            {
                Console.WriteLine($"Dr. Chaz needs {people - pieces} more {pieceOrPieces} of chicken!");
            }

        }
    }
}