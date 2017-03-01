using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int a, b;

            Random rand_num = new Random();

            Console.Write("Unsorted array: ");
            for (int i = 0; i < array.Length; i++)//generating array
            {
                array[i] = rand_num.Next(1, 101);
            }

            for (int i = 0; i < array.Length; i++)//Output unsorted array
                Console.Write(array[i] + " ");


            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < array.Length; i++)//Loop of insention sorting
            {
                a = array[i];
                b = i - 1;
                while (b >= 0 && array[b] > a) 
                {
                    array[b + 1] = array[b];
                    --b;
                }
                    array[b + 1] = a;
            }

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)//Output sorted array
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}
