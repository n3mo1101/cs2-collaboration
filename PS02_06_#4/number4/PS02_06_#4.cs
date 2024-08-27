using System;

namespace number4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string palindrome = Console.ReadLine();
            string check = new string(palindrome.Reverse().ToArray());

            if (palindrome == check)
            {
              Console.WriteLine("The word "+palindrome+ " is a palindrome");
            }           

            else
            {
              Console.WriteLine("The word "+palindrome+ " is not a palindrome");
            }          
        }
    }
}