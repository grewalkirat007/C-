using System;

namespace exponent_base
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the base");
            int baasee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the exponent");
            int exponent = Convert.ToInt32(Console.ReadLine());
            int answer=1;

            for (int i = 0; i<exponent;i++)
            {
                answer *= baasee;
            }
            Console.Write("Answer " + answer);
        }
    }
}
