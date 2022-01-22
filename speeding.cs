using System;

namespace Kattis3DPrintedStatues
{
    class Program
    {
        static void Main(string[] args)
        {
            int greatestSpeed = 0;
            int latestD = 0;
            int latestT = 0;




            int n = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x<n; x++)
            {

                string[] seperation = Console.ReadLine().Split(" ");
                int t = Convert.ToInt32(seperation[0]);
                int d = Convert.ToInt32(seperation[1]);

                int time = t - latestT;
                int distance = d - latestD;

                int milesPerHour = 0;

                if (time > 0)
                {
                    milesPerHour = distance / time;

                }

                if (milesPerHour > greatestSpeed)
                {
                    greatestSpeed = milesPerHour;
                }


                latestT = t;
                latestD = d;

            }

            Console.WriteLine(greatestSpeed);

            





        }
    }
}
