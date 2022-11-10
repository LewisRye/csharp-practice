using System;

namespace BitonicChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many elements would you like in your array?: ");
            int NoOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] array = new int[NoOfElements];

            for (int i = 0; i < NoOfElements; i++)
            {
                Console.Write($"Enter the value of index {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //

            Console.WriteLine(isBitonic(array));
            Console.ReadLine();
        }

        public static bool isBitonic(int[] array)
        {
            int i = 0;
            int n = array.Length - 1;

            while ((i < n - 1) && (array[i + 1] > array[i]))
            {
                i = i + 1;
            }

            while ((i > 1) && (i < n) && (array[i + 1] < array[i]))
            {
                i = i + 1;
            }

            return (i == n);
        }
    }
}
