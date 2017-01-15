/*
 * Innocent Niyibizi
 * 2-2-16
 * Create a program with a class that will hold the information of a motorway
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Motorway
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorWay motorWay = new MotorWay(); //Creating a new instance of the motorway class
            //Checking to make sure that the user inputs a name for the motorway
            #region nameCheck 
            for (bool val = false; val == false; )
            {
                Console.Write("Please enter the name of the motorway: ");
                motorWay.Name = Console.ReadLine();
                if (motorWay.Name.TrimStart().Length == 0)
                {
                    Console.WriteLine("Error; Name of motorway not inputed!");
                }
                else {
                    val = true;
                }
            }
            #endregion                                                     

            //Checking to make sure that the user enters a type for the motorway (North, South, East, or West)
            #region typeCheck
            Console.Clear();
            for (bool val = false; val == false; )
            {
                Console.Write("Please enter the direction of the motorway <North, South, East, West>: ");
                motorWay.Type = Console.ReadLine();
                motorWay.Type = motorWay.Type.ToUpper();
                motorWay.Type = motorWay.Type.Trim();
                if (motorWay.Type.Length == 0 || motorWay.Type != "N" && motorWay.Type != "S" && motorWay.Type != "E" && motorWay.Type != "W" && motorWay.Type != "NORTH" && motorWay.Type != "SOUTH" && motorWay.Type != "EAST" && motorWay.Type != "WEST")
                {
                    Console.WriteLine("Error; Type of motorway was invalid!");
                }
                else
                {
                    val = true;
                }
            }
            #endregion

            //Checking to make sure that the user enters a surface type for the motorway
            #region Surface
            Console.Clear();
            for (bool val = false; val == false; )
            {
                Console.Write("Please enter the surface of the motorway <blacktop, gravel, sand, concrete>: ");
                motorWay.Surface = Console.ReadLine();
                motorWay.Surface = motorWay.Surface.TrimStart();
                if (motorWay.Surface.Length == 0 || motorWay.Surface.ToUpper() != "BLACKTOP" && motorWay.Surface.ToUpper() != "GRAVEL" && motorWay.Surface.ToUpper() != "SAND" && motorWay.Surface.ToUpper() != "CONCRETE")
                {
                    Console.WriteLine("Error; Surface of motorway was not valid!");
                }
                else
                {
                    val = true;
                }
            }
            #endregion

            //Checking to make sure that the user inputs an integer for the amount of lanes on the motorway
            #region laneCheck
            Console.Clear();
            for (bool val = false; val == false; )
            {
                Console.Write("Please enter the number of lanes on the motorway: ");
                try
                {
                    motorWay.NumLanes = int.Parse(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("An integer must be entered!");
                    continue;
                }
                if (motorWay.NumLanes == 0)
                {
                    Console.WriteLine("Error; Number of lanes on the motorway were not inputted!");
                }
                else
                {
                    val = true;
                }
            }
            #endregion

            //Making sure that the user enters a Y or N to indicate if the motorway has a tool
            #region TollCheck
            Console.Clear();
            for (bool val = false; val == false; )
            {
                string temp = "";
                Console.Write("Is there a toll on {0}? <Y or N>: ", motorWay.Name);
                temp = Console.ReadLine().ToUpper();
                if (temp != "Y" && temp != "N")
                {
                    Console.WriteLine("Error; Y or N must be inputted!");
                }
                else
                {
                    val = true;
                    if (temp == "Y")
                        motorWay.Toll = true;
                    else
                        motorWay.Toll = false;
                }
            }
            #endregion

            //checking to make sure that the user enters a party for the motorway
            #region PartyCheck
            Console.Clear();
            for (bool val = false; val == false; )
            {
                Console.Write("Please enter the party that manages the motorway: ");
                motorWay.Party = Console.ReadLine();
                motorWay.Party = motorWay.Party.Trim();
                if (motorWay.Party.Length == 0)
                {
                    Console.WriteLine("Error; Party of the motorway was not inputted!");
                }
                else
                {
                    val = true;
                }
            }
            #endregion
               
            //Clearing the  console before printing out the motorway's information
            Console.Clear();

            //Printing out the motorway's information
            Console.WriteLine(motorWay.ToString());
            Console.ReadKey();
        }
    }
}
