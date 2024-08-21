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
             * Write a program that prints all the even numbers from 1 to 20 using a for loop.
             */
            int num = 1;

            for (int i = 0; i <21; i++)
            {
                 if (num %2 ==0)
                {
                 Console.WriteLine(num);
                }
                num++; 
            }
        }
    }
}
