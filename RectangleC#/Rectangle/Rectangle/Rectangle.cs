using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rectangle
    {
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
                if (value > 0.0)
                    length = value;
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
                if (value > 0.0)
                    width = value;
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
