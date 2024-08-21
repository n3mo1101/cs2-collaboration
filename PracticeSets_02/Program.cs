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
            //Prints all odd number 1-20
            int num = 1;
            for (int i=0; i<20; i++)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadKey();

        }
    }
}
