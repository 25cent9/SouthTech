/*
 
 Innoncet Niyibizi
 1-13-16
 Create a program that will gather the event type for a person and base the management and rate on the type
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LocalCaterer{
    class Program{
        static void Main(string[] args){
            string eventType = " ";
            string manager = " ";
            double rate = 0;

            GatherInput(ref eventType); //Calling the gathering info function
            FindManageAndRate(rt: ref rate, manage: ref manager, type: ref eventType);  //Calling the function to find the manaeger and the rate
            PrintInfo(rt:rate, management: manager, type: eventType);   //Calling the function to print the information
            Console.ReadLine();
        }
        private static void GatherInput(ref string type) {
            Console.Write("Please enter the type of event that you are having <Corperate, Private, Nonprofit, or Special>:  ");
            type = Console.ReadLine();
            type = type.ToUpper();
            while(type != "CORPORATE" && type != "C" && type!= "PRIVATE" && type != "P" && type != "NONPROFIT" && type != "N" && type != "SPECIAL" && type != "S"){ //Loop to run while the user input is not equal to any of the given choices 
                //Throwing an error and having user re-enter their selection
                Console.Write("Error; Ivalid input!\nPlease enter a correct selection: ");
                type = Console.ReadLine();
                type = type.ToUpper();
            }
        }
        private static void FindManageAndRate(ref string manage, ref string type, ref double rt) {  //Function to decide the manager and the rate based on the 
            if(type == "C" || type=="CORPORATE"){
                manage = "Pop";
                rt = 500;
                type = "Corporate";
            }
            else if (type == "P" || type == "PRIVATE"){
                manage = "Pop";
                rt = 300;
                type = "Private";
            }
            else if (type == "N" || type == "NONPROFIT"){
                manage = "Mom";
                rt = 150;
                type = "Nonprofit";
            }
            else if (type == "S" || type == "SPECIAL"){
                manage = "Mom";
                rt = 200;
                type = "Special";
            }
        }
        private static void PrintInfo(double rt, string type, string management) {  //Function to print the information to the console
            Console.Clear();
            Console.Write("Event Type: {0}\nManager: {2}\nRate: {1:c2}",type, rt, management);
        }
    }
}
