/*
 * Herzlia Jane R. Barangan
 * ITD103 Modern Query Languages
 * Array 01 Challenge
 * Date: 10/30/2021
 * 
 */



using System;

namespace array01
{
    class array1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program in C# to store elements in an array and print it.\n");

            while (true)
            {

            int[] arr = new int[10];
            int i;

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nElements in array are: ");
            Console.ResetColor();
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n\n");
            }
        }
    }
}
