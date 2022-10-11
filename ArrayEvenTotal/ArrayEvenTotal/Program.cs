using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEvenTotal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements would you like in the array?: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];
            int total = 0;

            for (int i = 0; i < input; i++) 
            {
                Console.Write($"\nEnter the value at array element {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            Console.WriteLine($"\nThe total of all the even numbers in this array is: {total}");

            Console.ReadLine();
        }

    }
}
