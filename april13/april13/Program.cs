using System;

namespace april13
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 5;
            double h = 6;
            double w = 7;
            double a = 9;
            double r = 8;
            double angle = 5;

            //user input for choosing case.
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    //triangle area
                    double triangle = 0.5 * b * h;
                    Console.WriteLine("Area of Triangle : " + triangle);
                    break;

                case 2:
                    //rectangle area
                    double rectangle = w * h;
                    Console.WriteLine("Area of rectangle : " + rectangle);
                    break;

                case 3:
                    //trapezoid or trapezium area
                    double trapezoid = 0.5 * (a + b) * h;
                    Console.WriteLine("Area of Trapezoid : " + trapezoid);
                    break;

                case 4:
                    //ellipse area
                    double ellipse = (22 / 7) * a * b;
                    Console.WriteLine("Area of Ellipse : " + ellipse);
                    break;

                case 5:
                    //square area
                    double square = a * a;
                    Console.WriteLine("Area of Square : " + square);
                    break;

                case 6:
                    //parallelogram area
                    double parallelogram = b * h;
                    Console.WriteLine("Area of Parallelogram : " + parallelogram);
                    break;

                case 7:
                    //circle area and circumference
                    double circle1 = (22 / 7) * r * r;
                    double circle2 = 2 * (22 / 7) * r;
                    Console.WriteLine("Area of Circle : " + circle1);
                    Console.WriteLine("Circumference of Circle : " + circle2);
                    break;

                case 8:
                    //sector area
                    double sector = 0.5 * r * r * angle;
                    Console.WriteLine("Area of Sector : " + sector);
                    break;

             
            }



            }
    }
}
