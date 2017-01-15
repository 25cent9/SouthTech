/*
 *Innocent Niyibizi
 *1-13-16
 * Create a program to gather the amount of taxes a user will pay based on their income and their marital status
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaxAdvantage{
    class Program{
        static void Main(string[] args){
            //Declaring variables
            char status = ' ';
            double income = 0;
            double taxed;
            double taxAmount; 
            GatherInput(ref status, ref income);    //Calling the fucntion to gather input
            taxed = calcTaxAmount(income, status);  //Calling function to return the amount taxed
            taxAmount = income - taxed;
            Console.Clear();
            Console.Write("Marital Status:\t\t {0}\nIncome:\t\t\t {1:c2}\nAmount Taxed:\t\t {2:c2}\n\nAmount after Taxt:\t {3:c2}",status,income,taxed,taxAmount);
            Console.ReadLine();
        }
        //Function to gather the input from the user
        public static void GatherInput(ref char stat, ref double money) {
            string temp = " ";
            Console.Write("Please enter your marital status <m or s>: ");
            temp = Console.ReadLine().ToUpper();
            stat = char.Parse(temp);
            temp = null;
            while (stat != 'S' && stat != 'M') {    //Loop to run as long as the user enters a value except for S or M
                Console.WriteLine("Error; Invalid entry!");
                Console.Write("Please renter: ");
                temp = Console.ReadLine().ToUpper();
                stat = char.Parse(temp);
                temp = null;
            }
            Console.Write("Please enter your income: ");
            money = double.Parse(Console.ReadLine());
        }
        //Function to calculate the amount taxed from the user
        public static double calcTaxAmount(double money, char stat) {
            if (stat == 'S')    //Checking the marital status of the user
            {
                if (money < 10000)  //Checking the income and basing their  taxes on that
                {
                    return (money * 0.15);  //Returning the amount taxed to the main function
                }
                else
                {
                    return (money * 0.30);
                }
            }
            else {
                if(money<20000){
                    return (money*0.15);
                }
                else{
                    return  (money*0.30);
                }
            }
        }
    }
}
