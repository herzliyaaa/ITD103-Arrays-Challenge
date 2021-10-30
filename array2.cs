/*
 * Herzlia Jane Barangan
 * ITD103 Modern Query Languages
 * Array Challenge 02
 * Date: 10/30/2021
 * 
 */


using System;

namespace array02
{
    class array2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2. Write a program in C# to read n number of values in an array and display it in reverse order.\n");

            while(true)
            {

                int i, size;
                int[] array = new int[100]; 

                Console.Write("Input the number of elements to store in the array :");
                size = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nInput {0} number of elements in the array :", size);

                for (i = 0; i < size; i++)
                {
                    Console.Write("element - {0} : ", i);
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nThe values store into the array are : \n");
                Console.ResetColor();

                for (i = 0; i < size; i++)
                {
                    Console.Write("{0}  ", array[i]);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\nThe values store into the array in reverse are :\n");
                Console.ResetColor();

                for (i = size - 1; i >= 0; i--)
                {
                    Console.Write("{0}  ", array[i]);
                }
                Console.WriteLine("\n\n");



            }

        }
    }
}
