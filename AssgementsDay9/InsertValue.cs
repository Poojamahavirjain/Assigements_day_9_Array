using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class InsertValuesOfArray
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an Array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Elements into An Array: ");
            int[] num = new int[size];
            int[] arr = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int value;
            Console.WriteLine("Enter the Value to insert: ");
            value = Convert.ToInt32(Console.ReadLine());
            int index;
            Console.WriteLine("Enter the Index Number to insert in an array less than the size: ");
            index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    arr[index] = value;

                }
                else
                {
                    arr[i] = num[i];
                }

            }
            Console.Write("Array Element after Insertion: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }

        }

    }
}
