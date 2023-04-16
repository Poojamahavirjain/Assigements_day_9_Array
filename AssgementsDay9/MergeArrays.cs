using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgementsDay9
{
    internal class MergeOfArrays
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of first array: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of second Array");
            int size2 = Convert.ToInt32(Console.ReadLine());

            int size = size1 + size2;
            int[] value = new int[size];
            int count = 0;

            Console.WriteLine("Enter the elements into first an Array: ");
            int[] num1 = new int[size1];

            for (int i = 0; i < size1; i++)
            {
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements into Second Array: ");
            int[] num2 = new int[size2];


            for (int i = 0; i < size2; i++)
            {
                num2[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < size; i++)
            {


                if (i < size1)
                {
                    value[i] = num1[i];
                }
                else
                {

                    value[i] = num2[count];
                    count++;

                }

            }

            Console.WriteLine("The Merged Array Elements are: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " + value[i]);
            }

        }
    }
}
