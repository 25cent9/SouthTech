/*
 * Innocent Niyibi
 * 12/11/15
 * Create program to use methods to gather and display inputs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chp3_2
{
    class Program
    {
        static void Main(string[] args){
            string name = " ";
            string saying = " ";

            //Gathering name
            name = GatherInput(name, "Please enter your name: ");
            //Gathering saying
            saying = GatherInput(saying, "Please enter you favorite saying "+name+": ");
            displayInfo(name, saying);
            Console.Read();
        }
        //Method to gather input
        static string GatherInput(string value, string msg){
            Console.Write(msg);
            value = Console.ReadLine();
            return value;
        }
        //Method to display information
        static void displayInfo(string name, string say) {
            Console.WriteLine("<><><><><><><><><><><><><>");
            Console.WriteLine("<> " + name);
            Console.WriteLine("<> " + say);
            Console.WriteLine("<><><><><><><><><><><><><>");
        }
    }
}
