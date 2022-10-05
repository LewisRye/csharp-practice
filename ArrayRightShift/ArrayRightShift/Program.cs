using System;

namespace ArrayRightShift
{
    class Program
    {
        static void Main(string[] args)
        {
            // this program does a right shift on a user defined array m times

            Console.Write("How many elements would you like in the array: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            int[] array = new int[input];

            for (int i = 0; i < input; i++)
            {
                Console.Write($"Enter the value of element {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("How many shifts would you like?: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int length = array.Length;
            int temp = 0;

            for (int i = 0; i < m; i++)
            {
                temp = array[length - 1]; // the final value of the array

                for (int j = 0; j < length - 1; j++)
                {
                    array[length - j - 1] = array[length - j - 2];
                }

                array[0] = temp;
            }

            Console.Write($"\nYour array shifted right {m} times is: ");
            foreach (int value in array)
            {
                Console.Write(value);
            }

            Console.ReadLine();
        }
    }
}
