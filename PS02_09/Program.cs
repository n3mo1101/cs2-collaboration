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
             * Write a program that takes an array of numbers as input and outputs the sum of the numbers.
             */

        Console.Write("Number of values to add: ");
        int num = int.Parse(Console.ReadLine());

        int[] values = new int[num];
        int sum = 0;
        for (int i = 0; i < num; i++)
        {
            Console.Write($"Value {i+1}: ");
            values[i] = int.Parse(Console.ReadLine());
            sum += values[i];
        }
        Console.WriteLine($"Sum: {sum}");

        }
    }
}