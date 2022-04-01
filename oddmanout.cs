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
            int cases = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int i = 0; i < cases; i++)
            {
                int guests = Convert.ToInt32(Console.ReadLine());
                string[] invitationCodes = Console.ReadLine().Split();

                for (int j = 0; j < guests; j++)
                {

                    int tempValue = 0;
                    for (int k = 0; k < guests; k++)
                    {
                        if (invitationCodes[j] == invitationCodes[k]) tempValue++;
                    }
                    if (tempValue == 1) result = invitationCodes[j];
                }
                Console.WriteLine($"Case #{i+1}: {result}");
            }
        }
    }
}