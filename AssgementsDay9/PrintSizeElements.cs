using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class PrintSizeElementsOfArray
         {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];

            Console.WriteLine("Enter elements into the array", size);
            for (int i = 0; i < size; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements of an array  are: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(" " + num[i]);
            }

        }

    }
}
