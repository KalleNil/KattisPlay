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
            string JonSays = Console.ReadLine();
            string DoctorSays = Console.ReadLine();

            if (JonSays.Length < DoctorSays.Length) Console.WriteLine("no");
            else Console.WriteLine("go");
        }
    }
}