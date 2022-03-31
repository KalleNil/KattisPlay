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
            int bites = Convert.ToInt32(Console.ReadLine());

            string[] babyCounting = Console.ReadLine().Split(" ");

            bool result = true;

            int currentCount = 1;

            for (int i = 0; i < bites; i++)
            {
                try
                {
                    if (Convert.ToInt32(babyCounting[i]) == currentCount) currentCount++;
                    else
                    {
                        result = false;
                    }

                }
                catch
                {
                    currentCount++;
                }
            }

            if (result == true)Console.WriteLine("makes sense");
            else Console.WriteLine("something is fishy");
        }
    }
}