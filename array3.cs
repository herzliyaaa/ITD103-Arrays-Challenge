/*
 * Herzlia Jane R. Barangan
 * ITD103 Modern Query Languages
 * Array 03 Challenge
 * Date: 10/30/2021
 * 
 */

using System;

namespace array03
{
    class array3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3.Write a program in C# to find the sum of all elements of the array.\n");

            while (true)
            {
                int[] array = new int[100];
                int i, size, sum = 0;

                Console.Write("Input the number of elements to be stored in the array :");
                size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", size);
                for (i = 0; i < size; i++)
                {
                    Console.Write("Element - {0} : ", i);
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 0; i < size; i++)
                {
                    sum += array[i];
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sum of all elements stored in the array is : {0}\n\n", sum);
                Console.ResetColor();
            }
        }
    }
}
