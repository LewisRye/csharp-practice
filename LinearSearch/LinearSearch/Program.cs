using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Search -> ");
            string search = Console.ReadLine();

            Program p = new Program();

            string[] list = new string[5];
            list[0] = "The first item";
            list[1] = "The second item";
            list[2] = "The third item";
            list[3] = "The fourth item";
            list[4] = "The fifth item";

            int index = p.linear_search(list, search);

            if(index == -1)
            {
                Console.WriteLine($@"'{search}' does not exist in the list.");
            }
            else
            {
                Console.WriteLine($@"'{search}' exists in the list at index {index}.");
            }

            Console.ReadLine();
        }

        public int linear_search(string[] items, string search_item)
        {
            int index = -1;

            for (int current = 0; current < items.Length - 1; current++)
            {
                if (items[current] == search_item)
                {
                    index = current;
                }
            }

            return index;
        }
    }
}
