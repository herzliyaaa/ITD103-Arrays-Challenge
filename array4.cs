/*
 * Herzlia Jane Barangan
 * ITD103 Modern Query Languages
 * Array Challenge 04
 * Date: 10/30/2021
 * 
 */


using System;

namespace array04
{
    class array4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. Write a program in C# to copy the elements of one array into another array.\n");

            while (true)
            {

                int[] array1 = new int[100];
                int[] array2 = new int[100];
                int i, size;

           

                    Console.Write("Input the number of elements to be stored in the array :");
                    size = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Input {0} elements in the array :\n\n", size);

           

                        for (i = 0; i < size; i++)
                        {
                         Console.Write("Element - {0} : ", i);
                         array1[i] = Convert.ToInt32(Console.ReadLine());
                        }
                
                       
                        for (i = 0; i < size; i++)
                        {
                        array2[i] = array1[i];
                        }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\nThe elements stored in the first array are :\n");
                    Console.ResetColor();

                        for (i = 0; i < size; i++)
                        {
                        Console.Write(array1[i] + " ");
                        }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\n\nThe elements copied into the second array are :\n");
                    Console.ResetColor();

                        for (i = 0; i < size; i++)
                        {
                        Console.Write(array2[i] + " ");
                        }
                        Console.Write("\n\n");
               
        }
        }

    }
}


