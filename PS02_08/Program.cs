using System;

namespace PracticeSets_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a program that takes a number as input and outputs the sum of its digits.
             */
        
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        Console.WriteLine($"Sum: {sum}");
        
        }
    }
}