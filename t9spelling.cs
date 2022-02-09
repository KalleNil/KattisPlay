using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{
    class Program
    {
        static void Main(string[] args)
        {

            int testCases = Convert.ToInt32(Console.ReadLine());

            Dictionary<char, string> charNumEqvil = new Dictionary<char, string>();
            charNumEqvil.Add('a', "2");
            charNumEqvil.Add('b', "22");
            charNumEqvil.Add('c', "222");
            charNumEqvil.Add('d', "3");
            charNumEqvil.Add('e', "33");
            charNumEqvil.Add('f', "333");
            charNumEqvil.Add('g', "4");
            charNumEqvil.Add('h', "44");
            charNumEqvil.Add('i', "444");
            charNumEqvil.Add('j', "5");
            charNumEqvil.Add('k', "55");
            charNumEqvil.Add('l', "555");
            charNumEqvil.Add('m', "6");
            charNumEqvil.Add('n', "66");
            charNumEqvil.Add('o', "666");
            charNumEqvil.Add('p', "7");
            charNumEqvil.Add('q', "77");
            charNumEqvil.Add('r', "777");
            charNumEqvil.Add('s', "7777");
            charNumEqvil.Add('t', "8");
            charNumEqvil.Add('u', "88");
            charNumEqvil.Add('v', "888");
            charNumEqvil.Add('w', "9");
            charNumEqvil.Add('x', "99");
            charNumEqvil.Add('y', "999");
            charNumEqvil.Add('z', "9999");
            charNumEqvil.Add(' ', "0");

            for (int i = 0; i < testCases; i++)
            {
                string testCase = Console.ReadLine();
                string lastChar = "";
                string result = "";
                for (int j = 0; j < testCase.Length; j++)
                {
                    if (lastChar.Length > 0)
                    {
                        string current = charNumEqvil[testCase[j]];
                        if (Convert.ToString(current[0]) == Convert.ToString(lastChar[0])) 
                        {
                            result += " " + charNumEqvil[testCase[j]];
                            lastChar = Convert.ToString(result[result.Length - 1]);
                        }
                        else
                        {
                            result += charNumEqvil[testCase[j]];
                            lastChar = Convert.ToString(result[result.Length - 1]);
                        }
                    }
                    else
                    {
                        result += charNumEqvil[testCase[j]];
                        lastChar = Convert.ToString(result[result.Length - 1]);
                    }
                }
                
                Console.WriteLine($"Case #{i+1}: {result}");
            }
        }
    }
}
