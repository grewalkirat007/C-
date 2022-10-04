using System;

namespace Powerbill
{
    class Program
    {
        static void Main(string[] args)   
        {
            //total kwh's used
            Console.WriteLine("Current meter reading");
            int currentmeterreading = Convert.ToInt32(Console.ReadLine());
            int lastmeterreading = 39803;

            int totalkWhsused = (currentmeterreading - lastmeterreading);
            Console.WriteLine("Current meter reading = " + currentmeterreading);
            Console.WriteLine("Meter reading reported on last month's bill = " + lastmeterreading);
            Console.WriteLine("Total kWh's used = " + totalkWhsused);

            //total energy charge
            double chargeperkwh = 0.095;
            double totalenergycharge = totalkWhsused * chargeperkwh;
            Console.WriteLine("Total kWh's used = " + totalkWhsused);
            Console.WriteLine("Charge per kWh = " + chargeperkwh);
            Console.WriteLine("Total energy charge = " + totalenergycharge);

            //total bill
            int standardmonthlyfees = 10;
            double totalbill = totalenergycharge + standardmonthlyfees;
            Console.WriteLine("Total kWh's used = " + totalkWhsused);
            Console.WriteLine("Standard monthly fees = " + standardmonthlyfees);
            Console.WriteLine("Total bill = " + totalbill);


        }
    }
}
