/*
 *Innocent Niyibizi
 *1-12-16
 *Practice Try/Catch
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace divideTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;    //Declaring variables
            GatherNums(out a, out b);   //Gathering input

                try
                {   //Trying the given statement
                    total = a / b;
                }
                catch
                {  //Catching the error
                    Console.WriteLine("Divide by zero error");
                }
            
            Console.ReadLine();
        }

        //Method to gather inputs
        public static void GatherNums(out int first, out int second) {
            Console.Write("Please enter your first number: ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Please enter your second number: ");
            second = int.Parse(Console.ReadLine());
        }
    }
}
