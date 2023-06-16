using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLeftShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shift once to the left.");

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int temp = 0;

            temp = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i+1];
            }

            array[array.Length - 1] = temp;

            foreach (int i in array)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }
    }
}
