using System;

namespace april13_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j, n;
            int[,] a1 = new int[10, 10];
            int[] r = new int[10];
            int[] c = new int[10];

            Console.WriteLine("Find sum of row an column of a Matrix: ");
            
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input elements in the matrix :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", a1[i, j]);
                Console.Write("\n");
            }

            
            for (i = 0; i < n; i++)
            {
                r[i] = 0;
                for (j = 0; j < n; j++)
                    r[i] = r[i] + a1[i, j];
            }

            
            for (i = 0; i < n; i++)
            {
                c[i] = 0;
                for (j = 0; j < n; j++)
                    c[i] = c[i] + a1[j, i];
            }

            Console.WriteLine("The sum or rows and columns of the matrix is :");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}    ", a1[i, j]);
                Console.Write("{0}    ", r[i]);
                Console.Write("\n");
            }
            Console.Write("\n");
            for (j = 0; j < n; j++)
            {
                Console.Write("{0}   ", c[j]);
            }
            

        }
    }
}

