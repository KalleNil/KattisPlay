using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven = 0;
            while (true)
            {
                int numberOfSets = Convert.ToInt32(Console.ReadLine());
                if(numberOfSets == -1)
                {
                    return;
                }
                
                int milesLastLoop = 0;
                for (int i = 0; i < numberOfSets; i++)
                {
                    string[] input = Console.ReadLine().Split();



                    int s = Convert.ToInt32(input[0]);
                    int t = Convert.ToInt32(input[1]);

                    int drivenDistance = t - milesLastLoop;



                    milesDriven += drivenDistance * s;
                    milesLastLoop = t;
                }
                Console.WriteLine(milesDriven + " miles");
                milesDriven = 0;

            }
        } 
    }
}