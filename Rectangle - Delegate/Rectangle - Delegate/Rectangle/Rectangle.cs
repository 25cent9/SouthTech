using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
        //The following statement invoked when 
        //  the Length property of the Rectangle
        //  object is changed.
        // The delegate of the Changed event 
        //    is the EventHandler type.
        //The event (Changed) is invoked when the
        //    set accessor of the Length property 
        //    is called.
        public event EventHandler Changed, Cherries;
        private double length;
        private double width;

        public double Length
        {
            get    //get accessor is used to return the property value
            {
                return length;
            }
            set    //set accessor is used to assign a new value to the property.
            {
                length = value;
                Changed(this, EventArgs.Empty);
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                
                    width = value;
                    Cherries(this, EventArgs.Empty);
            }
        }
        /*public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }  */
        public double GetArea()
        {
            return length * width;
        }
    }
}
