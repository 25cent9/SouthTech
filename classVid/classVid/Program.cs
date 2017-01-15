using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classVid{

    class Program{

        static void Main(string[] args){
            Dog theDog = new Dog();
            theDog.Breed = "Pug";
            theDog.Color = "Brown";
            theDog.Type = "Dog";
            for (int i = 0; i < 10;)
            {
                theDog.WagTail();
            }
            Console.ReadKey();
        }
    }
}
