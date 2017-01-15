using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Motorway
{
    class MotorWay
    {
        //Member variables
        private String name;
        private string type;
        private string surface;
        private int numLanes;
        private bool toll;
        private string party;

        //Get and set value of name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Get and set value of type
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        //Get and set the value of surface
        public string Surface
        {
            get
            {
                return surface;
            }
            set
            {
                surface = value;
            }
        }

        //Get and set the value of Number of lanes
        public int NumLanes
        {
            get
            {
                return numLanes;
            }
            set
            {
                numLanes = value;
            }
        }

        //Get and set the toll status
        public bool Toll
        {
            get
            {
                return toll;
            }
            set
            {
                toll = value;
            }
        }

        //Get and set the value of the party 
        public string Party
        {
            get
            {
                return party;
            }
            set
            {
                party = value;
            }
        }

        //Method to display just the MotorWay's name
        public void Display()
        {
            Console.WriteLine("Name: {0}",name);
        }

        //Method to display the motorway's name and toll status
        public void DisplayToll()
        {
            Console.WriteLine("Name: {0}\nToll: {1}", name, toll);
        }

        //Method to display the motorway's name and number of lanes
        public void DisplayLanes()
        {
            Console.WriteLine("Name: {0}\nLanes: {1}", name, numLanes);            
        }

        //Method to display all the properties of the motorway
        public override string ToString()
        {
            return "Name: "+name+"\nParty: "+party+"\nType: "+type+"\nSurface: "+surface+"\nLanes: "+numLanes+"\nToll: "+toll;
        }
    }
}
