using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements would you like in your array?: ");
            int NoOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] Input = new int[NoOfElements];

            for (int i = 0; i < NoOfElements; i++)
            {
                Console.Write($"Enter the value of index {i}: ");
                Input[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool Palindrome = true;

            for (int i = 0; i < NoOfElements / 2; i++)
            {
                if (Input[i] != Input[NoOfElements - i - 1])
                {
                    Palindrome = false;
                }
            }

            Console.WriteLine($"\nPalindrome: {Palindrome}");

            Console.ReadLine();
        }
    }
}
