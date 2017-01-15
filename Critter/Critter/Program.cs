/*
 *  Innocent Niyibizi
 *  2-3-16
 *  Create a program that has a class for a critter object
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Critter{
    class Program{
        static void Main(string[] args){
            //Creating a critter with
           ClassCritter cv = new ClassCritter ();
           cv.Name = "alpha";
           cv.Full = 10;
           cv.Happiness = 10;
           cv.Age = 0;
           cv.Talk();
           Console.ReadKey();
        }
    }
}
