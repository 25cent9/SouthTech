using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpArray{
    class Program{
        static void Main(string[] args){
            double[] balance;           //Instantiating balance
            
            balance = new double[10];   //Creating a new array by the name of balance that has 10 elements

            int[] marks = new int[5] { 99, 98, 92, 92, 22 };    //Five element array

            int[] n = new int[10];  //n is an array of integers

            int i, j;

            //initalize elements of the array
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            //Printing out n
            for (j = 0; j < 10; j++ )
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            foreach (int elelement in n){
                Console.WriteLine(elelement);
            }



            string[] arr1 = new string[]{
                "one","two","three"
            };
            string[] arr2 = new string[]{
                "one","two","three"
            };

            Console.ReadKey();
        }
    }
}
