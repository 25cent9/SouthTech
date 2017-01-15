/*
 * Innocent Niyibizi
 * 12/2/15 
 * Create program to convert from miles to feet
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mileToFeet{
    class Program{
        static void Main(string[] args){
            double miles = 4.5;
            double feet = 0;
            double inches = 0;
            feet = miles * 5280;
            inches = feet * 12;
            Console.WriteLine("Miles: {0:f2}",miles);
            Console.WriteLine("Feet: {0:f0}", feet);
            Console.WriteLine("Inches: {0:f0}", inches);

            Console.Read();
        }
    }
}
