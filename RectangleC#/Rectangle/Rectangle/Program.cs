using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //You create an object by using the "new" keyword 
            //followed by the call to the appropriate class constructor

            //Constructors are used to initialize the data members of the object

            //Rectangle rect = new Rectangle(10.0, 20.0);
            //*******************************************
            Rectangle rect = new Rectangle();  //create new object
            rect.Length = 10.0;
            rect.Width = 20.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area); 


        }
    }
}
