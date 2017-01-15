/*
 * Innocent Niyibizi
 * 12/1/15
 * Create program to print my initials in block form using my initials 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace initials{
    class Program{
        static void Main(string[] args){
            Console.Write("IIIIIII\t\tN\tN\n"); //Top part of the I and N
            Console.Write("   I\t\tNN\tN\n");   //Rest of the I and N
            Console.Write("   I\t\tN N     N\n");
            Console.Write("   I\t\tN  N    N\n");
            Console.Write("   I\t\tN   N   N\n");
            Console.Write("   I\t\tN    N  N\n");
            Console.Write("   I\t\tN     N N\n");
            Console.Write("   I\t\tN      NN\n");
            Console.Write("IIIIIIII\tN       N\n");
            Console.Read();
        }
    }
}
