using System;
using System.Collections.Generic;
using System.Linq;

namespace SammaSolutionNyaKattis
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> bokstäver = new Dictionary<char, string>();

            bokstäver.Add('a', "@");
            bokstäver.Add('b', "8");
            bokstäver.Add('c', "(");
            bokstäver.Add('d', "|)");
            bokstäver.Add('e', "3");
            bokstäver.Add('f', "#");
            bokstäver.Add('g', "6");
            bokstäver.Add('h', "[-]");
            bokstäver.Add('i', "|");
            bokstäver.Add('j', "_|");
            bokstäver.Add('k', "|<");
            bokstäver.Add('l', "1");
            bokstäver.Add('m', "[]\\/[]");
            bokstäver.Add('n', "[]\\[]");
            bokstäver.Add('o', "0");
            bokstäver.Add('p', "|D");
            bokstäver.Add('q', "(,)");
            bokstäver.Add('r', "|Z");
            bokstäver.Add('s', "$");
            bokstäver.Add('t', "']['");
            bokstäver.Add('u', "|_|");
            bokstäver.Add('v', "\\/");
            bokstäver.Add('w', "\\/\\/");
            bokstäver.Add('x', "}{");
            bokstäver.Add('y', "`/");
            bokstäver.Add('z', "2");
            bokstäver.Add(' ', " ");

            string result = "";


            string input = Console.ReadLine().ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (bokstäver.ContainsKey(input[i])){
                    result += bokstäver[input[i]];
                }
                else
                {
                    result += input[i];
                }
               
            }

            Console.WriteLine(result);
        } 
    }
}
