
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class CountEvenOddNumberOfArray
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of an array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements in an array: ");
            int[] num = new int[size];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
            Console.WriteLine("The Count of Even Numbers are: " + countEven);
            Console.WriteLine("The Count of Odd Numbers are: " + countOdd);
        }
    }
}

    