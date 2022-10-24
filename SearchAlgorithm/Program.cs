using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    class Program
    {
        int[] arr = new int[20];

        int n;

        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter The Number of Elements in Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);

                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter array element");
            Console.WriteLine("-------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (1 + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void BinarySearch()
        {
            char ch;
            do
            {
                Console.Write("\nEnter element you want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of Comparison: " + ctr);

                Console.Write("\nContinue Searching? (n/y): ");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
        }
    }
}
