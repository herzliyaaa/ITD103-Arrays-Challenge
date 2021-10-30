
/*
 * Herzlia Jane R. Barangan
 * ITD103 Modern Query Languages
 * Array 05 Challenge
 * Date: 10/30/2021
 * 
 */

using System;

namespace array05
{
    class array5
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5. Write a program in C# to count a total number of duplicate elements in an array.\n\n");

            while (true)
            {

                int[] array1 = new int[100];
                int[] array2 = new int[100];
                int[] array3 = new int[100];
                int duplicate = 1, count = 0;
                int size, i, j;

               
                Console.Write("Input the number of elements to be stored in the array :");
                size = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", size);
                for (i = 0; i < size; i++)
                {
                    Console.Write("Element - {0} : ", i);
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }


                for (i = 0; i < size; i++)
                {
                    array2[i] = array1[i];
                    array3[i] = 0;
                }


                for (i = 0; i < size; i++)
                {
                    for (j = 0; j < size; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            array3[j] = duplicate;
                            duplicate++;
                        }
                    }
                    duplicate = 1;
                }

                for (i = 0; i < size; i++)
                {
                    if (array3[i] == 2) { count++; }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("The number of duplicate elements is: {0} \n", count);
                Console.ResetColor();
                Console.Write("\n\n");
            }
        }
    }

}