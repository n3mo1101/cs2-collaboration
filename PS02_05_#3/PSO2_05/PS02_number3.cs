using System;

namespace PSO2_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i'   || letter == 'o' || letter == 'u')
            {
              Console.WriteLine("The letter " +letter+ " is a vowel ");
            }
            else
            {
              Console.WriteLine("The letter " +letter + " is a consonant");
            }
        }
    }
}