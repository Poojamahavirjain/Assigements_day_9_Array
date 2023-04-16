using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class SunOfArray
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in to an Array: ");
            int[] num = new int[size];
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("The sum of arrays are: " + sum);

        }

    }
}
