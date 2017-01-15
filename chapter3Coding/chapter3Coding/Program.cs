/**
 * Innocent Niyibizi
 * 1/11/16
 * Create program that will gather input, calculate toatl, and create a recipt using methods 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chapter3Coding{
    class Program{
        static void Main(string[] args){
            //Declaring variables
            string custName = "";
            string email = "";
            int amount = 0;
            const double PRICE = 0.99;
            const double SHIPPING = 2.00;
            const double TAX = 0.06;
            double total = 0;

            DisplayGreeting();  //Calling the greeting method
            Console.Clear();    //Clearing the console
            GatherInput(PRICE, ref custName, ref email, out amount);    //Calling the GatherInput method to recive input from the user
            Console.Clear();
            total = CalcTotal(amnt: amount, price: PRICE, shipping: SHIPPING, tax: TAX);    //Calling the CalcTotal method to find the total cost 
            DisplayRecipt(name: custName, mail: email, price:PRICE, tax: TAX, tot: total, amnt: amount, ship:SHIPPING); //Calling the DisplayRecipt method to display the recipt from the purchase
            Console.ReadLine();
        }

        //Method that will display the greeting message
        public static void DisplayGreeting() {
            Console.Write("Buzz Buttons\n".PadLeft(47));
            Console.Write("It starts the buzz!\n".PadLeft(50));
            Console.Write("Press any button to continue".PadLeft(55));
            Console.ReadLine();
        }

        //Mehtod to gather the input
        public static void GatherInput(double price,ref string name, ref string mail, out int amnt) {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("{0}, Please enter your email address: ", name);
            mail = Console.ReadLine();
            Console.Write("{0}, The buttons are {1:c} each. How many would you like to order?: ",name, price);
            amnt = int.Parse(Console.ReadLine());
        }

        //Method to calulate the total, with the shipping
        public static double CalcTotal(double amnt, double price, double shipping, double tax) { 
            double temp = 0;
            temp = amnt*price;
            temp = temp+(temp*tax);
            return temp+shipping;             
        }

        //Method that will display all of the given and calulated information
        public static void DisplayRecipt(string name, double price, double tot, double tax, string mail, int amnt, double ship){
            Console.Write("Buzz Buttons\n".PadLeft(47));
            Console.Write("It starts the buzz!\n".PadLeft(50));
            Console.WriteLine("\n\nName: {0}\nEmail: {1}",name,mail);
            Console.WriteLine("Amount of buzzers purchased: {0}\nPrice <Per buzzer>: {1:c}\nSales Tax: {2:p}\nShipping: {3:c}\n\nTotal: {4:c}",amnt,price,tax,ship,tot);
        }
    }
}
