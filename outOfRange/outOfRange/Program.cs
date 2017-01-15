/*
 * Innocent Niyibizi
 * 1-13-16
 * Edit code to catch IndexOutOfRange exception
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace outOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = new string[5];

            list[0] = "Sunday";
            list[1] = "Monday";
            list[2] = "Tuesday";
            list[3] = "Wednesday";
            list[4] = "Thursday";

            for (int i = 0; i <= 5; i++){
                try{    //Try block to try the printing statment
                    Console.WriteLine(list[i].ToString());
                }
                catch (IndexOutOfRangeException){   //Catch for excpetion that occurs when idex is out of range 
                    break;  //Breaking out of loop
                }
                catch { //Default catch statement 
                    break;  //Breaking out of loop
                }
            }
            Console.ReadLine();
        }
    }
}
