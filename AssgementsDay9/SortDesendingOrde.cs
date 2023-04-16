using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class ArraySortDesendingOrdeOfArray
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the elements into an array: ");
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }

            }

            Console.WriteLine(" ");

            Console.WriteLine("The desending order is:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(" " + arr[i]);
            }
        }


    }
}
