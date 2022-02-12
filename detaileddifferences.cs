using System;
using System.Collections.Generic;
using System.Linq;

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
                string row1 = Console.ReadLine();
                string row2 = Console.ReadLine();

                for (int j = 0; j < row1.Length; j++)
                {
                    if(row1[j] == row2[j])
                    {
                        result += ".";
                    }
                    else
                    {
                        result += "*";
                    }
                }
                
               
                Console.WriteLine(row1);
                Console.WriteLine(row2);
                Console.WriteLine(result);
                Console.WriteLine();
                result = "";
            }

            
        }
    }
}
