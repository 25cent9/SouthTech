using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chp3_4
{
    class Program
    {
        static void Main(string[] args){
            int seconds;
            decimal hrs = 0m;
            double mins = 0d;
            Console.Write("Please enter the amount of seconds you wish to convert: ");
            seconds = int.Parse(Console.ReadLine());
            hrs = GetHours(seconds);
            Console.Write("Hours: "+hrs);
            Console.Read();
        }
        static decimal GetHours(int sec){
            int divisor = 3600;
            decimal hours = Convert.ToDecimal(sec) /Convert.ToDecimal(divisor);
            return  hours;
        }

        static double GetMinuites(int sec){
            double minutes = 0d;
            return minutes;
        }
    }
}
