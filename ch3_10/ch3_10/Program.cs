using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MILAGE_RATE = 10.03 / 1000;
            const int TAX_EXCEPTION = 25000;
            const double TAX_INCREASE = 0.27;
            double lastYear;
            double currentAssessed = 0;
            double taxable = 0;
            string address = " ";
            address = GetStreet();
            lastYear = GetLastYr();

            CalcCurrent(ref currentAssessed, TAX_INCREASE, lastYear);
            Console.Write("Street: {0} \nLast Year's Assessed Value: {1:c}\n\nCurrent Assessed Value: {2}",address,lastYear,currentAssessed);
            Console.ReadKey();
        }
        static void displaay() { 


        }
        static string GetStreet() {
            string input;
            Console.Write("Please enter your street address: ");
            input = Console.ReadLine();
            return input;
        }
        static double GetLastYr() {
            Console.WriteLine("Enter your assessed value from last year: ");
            return Console.Read();
           
        }
        static void CalcCurrent(ref double current, double tax, double last) {
            current = last +(last * tax);
        }
    }
}
