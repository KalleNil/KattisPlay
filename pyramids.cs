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
            int lastLayer = 0;
            int lastOuterLayer = 8;
            int result = 0;

            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && lastLayer == 0)
            {
                result++;
                input--;
            }
            if (input >= 9 && lastLayer < 9)
            {
                result++;
                input += -9;
                lastLayer = 9;
            }


            while (true)
            {
                
                if (input >= lastLayer + lastOuterLayer)
                {
                    lastOuterLayer += 8;
                    lastLayer += lastOuterLayer;
                    result++;
                    input += -lastLayer;

                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}