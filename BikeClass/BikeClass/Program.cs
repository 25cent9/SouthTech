/**
 * Innocent Niyibizi
 * 2-1-16
 * Create a program that will create a bike
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            bike MountainBike = new bike(); //Creating a new instance of the bike class called Mountain Bike
            MountainBike.Cadence = 35;      //Setting initial Cadence to 35
            MountainBike.SetGears(10);      //Setting initial gear to 10
            MountainBike.Speed= 24;         //Setting initial speed to 24

            Console.WriteLine("Cadence: {0}\nGear: {1}\nSpeed: {2}",MountainBike.Cadence, MountainBike.Gear, MountainBike.Speed);   //Displaying the bike's information
            Console.WriteLine("\nApplying brakes!");    
            MountainBike.ApplyBrakes(6);                                                                                            //Calling the method to decrease speed by 6
            Console.WriteLine("\nCadence: {0}\nGear: {1}\nSpeed: {2}", MountainBike.Cadence, MountainBike.Gear, MountainBike.Speed);
            Console.WriteLine("\nIncrementing speed!");
            MountainBike.IncreaseSpeed(10);                                                                                         //Calling the  method to increase speed by 10 
            Console.WriteLine("\nCadence: {0}\nGear: {1}\nSpeed: {2}", MountainBike.Cadence, MountainBike.Gear, MountainBike.Speed);
            Console.ReadKey();
        }
    }
}
