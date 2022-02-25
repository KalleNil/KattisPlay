using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            for (int i = 0; i < 5; i++)
            {
                string x = Console.ReadLine();

                if (x.Contains("FBI"))
                {
                   
                    if(result != "")
                    {
                        result += " ";
                    }
                    result += Convert.ToString(i + 1);
                }
            }
            if(result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("HE GOT AWAY!");
            }
        } 
    }
}
