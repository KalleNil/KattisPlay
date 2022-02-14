using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            char nextLetterShouldBe = 'P';
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] != nextLetterShouldBe)
                {
                    result++;
                    if(nextLetterShouldBe == 'P')
                    {
                        nextLetterShouldBe = 'E';
                    }
                    else if(nextLetterShouldBe == 'E')
                    {
                        nextLetterShouldBe = 'R';
                    }
                    else
                    {
                        nextLetterShouldBe = 'P';
                    }
                }
                else
                {
                    if (nextLetterShouldBe == 'P')
                    {
                        nextLetterShouldBe = 'E';
                    }
                    else if (nextLetterShouldBe == 'E')
                    {
                        nextLetterShouldBe = 'R';
                    }
                    else
                    {
                        nextLetterShouldBe = 'P';
                    }
                }
            }
            Console.WriteLine(result);
        } 
    }
}
