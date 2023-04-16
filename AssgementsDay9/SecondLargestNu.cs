using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class SecondLargestNuOfArray
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in an array: ");
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = num[0];
            int secondMax = num[0];

            for (int i = 0; i < size; i++)
            {

                if (num[i] > max)
                {
                    secondMax = max;
                    max = num[i];

                }
            }
            Console.WriteLine("Second Largest Number: " + secondMax);


        }

    }
}
