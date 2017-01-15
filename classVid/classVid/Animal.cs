using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classVid
{
    class Animal
    {
        //Member varaibles
        private string type;
        private double weight;
        private string color;
    
        //Properties
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

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        //Methods
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise");
        }

        public void Move()
        {
            Console.WriteLine("Animal is moving");
        }

    }
}
