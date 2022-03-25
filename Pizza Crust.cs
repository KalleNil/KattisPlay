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
            string[] pizza = Console.ReadLine().Split(" ");

            int radiusOfPizza = Convert.ToInt32(pizza[0]); 
            int radiusOfCrust = Convert.ToInt32(pizza[1]);

            double area1 = radiusOfPizza * radiusOfPizza * Math.PI;
            double area2 = (radiusOfPizza - radiusOfCrust) * (radiusOfPizza - radiusOfCrust) * Math.PI;
            Console.WriteLine(area2/area1 * 100);

        }
    }
}