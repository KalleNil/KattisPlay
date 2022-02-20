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
            int allaEleversBetyg = 0;
            decimal totalaElever = 0;
            decimal eleverMedHögreÄnAvg = 0;
            List<int> betyg = new List<int>();
            for (int i = 0; i < cases; i++)
            {
                string[] thisCase = Console.ReadLine().Split();

                for (int j = 1; j < Convert.ToInt32(thisCase[0])+1; j++)
                {
                    allaEleversBetyg += Convert.ToInt32(thisCase[j]);
                    betyg.Add(Convert.ToInt32(thisCase[j]));

                }
                totalaElever = Convert.ToInt32(thisCase[0]);
                decimal avg = allaEleversBetyg / totalaElever;
                foreach(int x in betyg)
                {
                    if (x > avg)
                    {
                        eleverMedHögreÄnAvg++;
                    }
                }
                decimal result = eleverMedHögreÄnAvg / totalaElever ;

                Console.WriteLine(result.ToString("0.000%" ));

                avg = 0;
                totalaElever = 0;
                eleverMedHögreÄnAvg = 0;
                betyg.Clear();
                allaEleversBetyg = 0;
            }
        } 
    }
}
