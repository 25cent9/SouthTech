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
            Rectangle r = new Rectangle();  //create new object

            //stmt below - you are subscribing to the Changed
            //     event by attaching the r_Changed method as 
            //     an event handler for the event
            // +=  This is used to attach the event handler
            // Also, you make sure that this event handler will be 
            //     added to a list of event handlers already
            //     attached with the event.
            // This allows you to have multiple event handlers that may 
            //     respond to an event.

            //r.xxxx must match what is in the class for the event handler

            r.Changed += new EventHandler(r_Changed);
            r.Cherries += new EventHandler(r_Cherries);

            r.Width = 15;
            r.Length = 10;
            r.Length = 20;
           

        }

        //subscribing to events  - the signature of the event handler
        //     method matches the requirements of the event's delegate
        static void r_Changed(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;

            Console.WriteLine("Value changed: Length = {0}", r.Length); 


        }
        static void r_Cherries(object sender, EventArgs e)
        {
            Rectangle r = (Rectangle)sender;

            Console.WriteLine("Value changed: width = {0}", r.Width);


        }
    }
}
