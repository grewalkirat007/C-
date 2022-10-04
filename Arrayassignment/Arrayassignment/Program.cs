using System;

namespace Arrayassignment
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 7, 3, 8, 4 };


            //1.Write a C# program and find minimum and maximum elements in a array 
            /*
            int minimum, maximum;
            minimum = maximum = arr[0];
            int i;
            for (i = 1; i < arr.Length; i++)
            {
                if (minimum > arr[i])
                    minimum = arr[i];

                if (maximum < arr[i])
                    maximum = arr[i];
            }

            Console.WriteLine("The maximum number : " + maximum);
            Console.WriteLine("The minimum number : " + minimum);
            */

            //2.Sort a array in ascending order than insert a element at the end










            /*
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            
            for (int x = 0; x < arr.Length; x++)
            {
                Console.Write("{0} ", arr[x]);
            }

            */



            //3.Sort a array in ascending order than delete element



            /*
            int i, j, t;
            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Ascending Order Array:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Deleting last element");
            for (i = 5; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            // Decrease size of array
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }*/

            //4.Find a first and second largest element in the array

            /*
            int i, j, a;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }

            for (i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            int largeNum1 = arr[arr.Length - 1];
            Console.WriteLine("First largest number = " + largeNum1);
            int largeNum2 = arr[arr.Length - 2];
            Console.WriteLine("Second largest number = " + largeNum2);*/





            //5.Enter a number at the specified index by the user

            /*

            for (int q = 0; q < arr.Length; q++)
                Console.WriteLine("Element number " + q + " - " + arr[q]);

            int i;


            Console.WriteLine("Enter index number to enter a element: ");

            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number you want to enter: ");

            arr[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The array is: ");


            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }*/

        }
    }
}
