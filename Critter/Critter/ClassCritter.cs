using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Critter
{
    class ClassCritter
    {
        //Member variables
        private string name;
        private int full;
        private int happiness;
        private int age;

        //Critter's name
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

        //Critter's fullness
        public int Full
        {
            get
            {
                return full;
            }
            set
            {
                full = value;
            }
        }

        //Critter's happiness
        public int Happiness
        {
            get
            {
                return happiness;
            }
            set
            {
                happiness = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //Critter's talking behavior
        public void Talk()
        {
            if (happiness > 5)
            {
                Console.WriteLine("I feel happy today!");
            }
            else if (happiness < 5 && happiness > 2)
            {
                Console.WriteLine(name + " doesn't feel so good...");
            }
            else if (happiness < 2 && happiness > 0)
            {
                Console.WriteLine(name + " is MAD... ");
            }
            else
            {
                Console.WriteLine("... nothing at all, but lays in a heap.");
            }
        }

        //Critter's playing behavior
        public void Play()
        {
            happiness += 3;
        }

        //Critter's aging behavior
        public void Aging()
        {
            age += 1;
            full -= 1;
            happiness -= 1;
            if (full < 3)
            {
                happiness -= 1; 
            }

        }

        //Critter's eating behavior
        public void Eat()
        {
            full += 4;
        }
    
    }
}
