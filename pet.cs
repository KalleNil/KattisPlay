using System;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {
            int personHighestScore = 0;
            int highestScore = 0;
            int personAtm = 1;




            for (int x = 0; x < 5; x++)
            {
                string[] inputGrades = Console.ReadLine().Split(" ");
                int person1Grade = Convert.ToInt32(inputGrades[0]);
                int person2Grade = Convert.ToInt32(inputGrades[1]);
                int person3Grade = Convert.ToInt32(inputGrades[2]);
                int person4Grade = Convert.ToInt32(inputGrades[3]);


                int sum = person1Grade + person2Grade + person3Grade + person4Grade;

                if(sum > highestScore)
                {
                    personHighestScore = personAtm;

                    highestScore = sum;

                }


                personAtm++;
            }
            Console.WriteLine($"{personHighestScore} {highestScore}");
        }
    }
}
