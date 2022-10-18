using System;

namespace OrderedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // this app sorts an array, but is not very efficient

            Console.Write("Number of Elements: ");
            int NoOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] unordered = new int[NoOfElements];

            for (int i = 0; i < NoOfElements; i++)
            {
                Console.Write($"Enter the value of element {i}: ");
                unordered[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < unordered.Length; i++)
            {
                for (int j = 0; j < unordered.Length - 1; j++)
                {
                    if (unordered[j] > unordered[j + 1])
                    {
                        int temp = unordered[j + 1];
                        unordered[j + 1] = unordered[j];
                        unordered[j] = temp;
                    }
                }
            }

            string output = "";

            foreach (int i in unordered)
            {
                output += i;
            }

            Console.WriteLine($"\nThis array, sorted, is {output}");

            Console.ReadLine();
        }
    }
}
