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
            int cases = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < cases; i++)
            {
                bool ChainsOfIceFollowedByDeathGrip = true;
                string battle = Console.ReadLine();
                for (int j = 0; j < battle.Length; j++)
                {
                    if (j < battle.Length -1)
                    {
                        if(battle[j] == 'C' && battle[j+1] == 'D')
                        {
                            ChainsOfIceFollowedByDeathGrip = false;
                        }
                    }
                }
                if (ChainsOfIceFollowedByDeathGrip) result++;
            }
            Console.WriteLine(result);
        }
    }
}