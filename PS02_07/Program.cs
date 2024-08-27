using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that takes a string as input and outputs the frequency of each character in the string.
             */

            Console.Write("Text: ");
            string text = Console.ReadLine().ToUpper();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (text.IndexOf(currentChar) == i)
                {
                    int frequency = 0;
                    foreach (char character in text)
                    {
                        if (character == currentChar)
                        frequency += 1;
                    }
                    Console.WriteLine($"{text[i]} : {frequency}");
                }
            }
        }
    }
}