using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOrderCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of elements in array: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write($"\n Enter the value of element {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            string arrayStr = "";
            bool inOrder = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i+1])
                {
                    inOrder = false;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                arrayStr += $"[{array[i]}] ";
            }

            if (inOrder)
            {
                Console.WriteLine($"\nThe array containing {arrayStr}is in ascending order...");
            }
            else
            {
                Console.WriteLine($"\nThe array containing {arrayStr}is NOT in ascending order...");
            }
            Console.ReadLine();
        }
    }
}
