using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 2.5;
            double y = 6.9;
            double z = 10.0;
            z *= y++ % 7;
            x = (int)y+(14-z/7);
            x = z/3*--y;
            z /= (int) y /x;
            z = x+y/4; 

        }
    }
}
