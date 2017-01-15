using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classVid
{
    class Dog:Animal    //Inherets from the anim,a
    {
        //Member variables
        private string breed;

        //Properties
        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        //Instance methods
        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }

        public void WagTail()
        {
            Console.WriteLine(breed+" is wagging its tail");
        }
    }
}
