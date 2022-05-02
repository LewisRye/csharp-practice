using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string[] list = new string[5];
            list[0] = "The first item";
            list[1] = "The second item";
            list[2] = "The third item";
            list[3] = "The fourth item";
            list[4] = "The fifth item";

            Console.Write("Search -> ");
            string search = Console.ReadLine();

            int index = p.binary_search(list, search);
            
            if (index == -1)
            {
                Console.WriteLine($@"'{search}' does not exist in the list.");
            }
            else
            {
                Console.WriteLine($@"'{search}' exists in the list at index {index}.");
            }

            Console.ReadLine();
        }

        public int binary_search(string[] items, string search_item)
        {
            int index = -1;
            bool found = false;
            int first = 0;
            int last = items.Length - 1;

            while(first <= last && found == false)
            {
                int midpoint = (first + last) / 2;

                if(items[midpoint] == search_item)
                {
                    index = midpoint;
                    found = true;
                }

                else if(String.Compare(items[midpoint], search_item) < 0)
                {
                    first = midpoint + 1;
                }

                else if(String.Compare(items[midpoint], search_item) > 0)
                {
                    last = midpoint - 1;
                }
            }

            return index;
        }
    }
}
