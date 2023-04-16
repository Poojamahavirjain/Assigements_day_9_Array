using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class CountNegativeElementOfArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in to the array: ");
            int[] num = new int[size];
            int count = 0;

            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("The number of negative elements in array are: " + count);
        }
    }
}
