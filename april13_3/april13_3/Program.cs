using System;

namespace april13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            Console.WriteLine("Sum : " + sum);
        }
    }
}
