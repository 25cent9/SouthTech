/*
 *Innocent Niyibizi
 *12/2/15
 *Create program to practice outputs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace markUp{
    class Program{
        static void Main(string[] args){
            double wholePrice = 52.00;
            double markUp = 0.15;
            double retailPrice = 0;
            retailPrice = wholePrice - (wholePrice * markUp);
            Console.WriteLine("Ruggy Shoes:\nWholesale Price: {0:c} \nRetail Price: {1:c} ",wholePrice, retailPrice);
            wholePrice = 71.00;
            retailPrice = wholePrice - (wholePrice * markUp);
            Console.WriteLine("\nTeno Jacket:\nWholesale Price: {0:c} \nRetail Price: {1:c} ", wholePrice, retailPrice);
            Console.Read();
        }
    }
}
