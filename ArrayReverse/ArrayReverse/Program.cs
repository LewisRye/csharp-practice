using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program reverses the contents of an array

            Console.Write("How many elements would you like in the array: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int[] Array = new int[input];

            for (int i = 0; i < input; i++)
            {
                Console.Write($"Enter the value of element {i}: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int length = Array.Length;
            int temp = 0;

            for (int i = 0; i < length / 2; i++)
            {
                temp = Array[length - 1];
                Array[length - 1] = Array[i];
                Array[i] = temp;
                length--;
            }

            Console.Write("\nThe reverse of your array is: ");

            foreach (int i in Array)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}