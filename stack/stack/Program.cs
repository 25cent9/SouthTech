using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static Stack<int> GetStack(){
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            stack.Push(1000);
            stack.Push(10000);

            //Push - pushes elements into the stack. (add to top)
            
            //Pop - pops elements from the top of the stack. physically removes the element 

            //Peek - Does not remove the element from the stack, only gets the value

            //Clear, count - you can use cleat to clear the stack and count will give the number of elements in the stack
            return stack;
        }

        static void Main(string[] args)
        {
            //Stack is a LIFO collection. It provides a simple last-in-first-out data structure. It can help parse quickly and also replace complex recursive algorithms
            var stack = GetStack();
            Console.WriteLine("---Stack Contents---");
            foreach (int i in stack) {
                Console.WriteLine(i);
            }

            //Pop the top element, 1000
            int pop = stack.Pop();

            Console.WriteLine("\n---Element popped form the top of the stack---");
            Console.WriteLine(pop);

            //Look at the top element in the stack but not take it off peek
            int peek = stack.Peek();
            Console.WriteLine("\n---Elelment peek from the top of the stack---");
            Console.WriteLine(peek);

            Console.WriteLine(stack.Count);

            //Clear the stack
            stack.Clear();
            Console.WriteLine("---Stack Cleared---");
            Console.WriteLine(stack.Count+"\n");

            string[] values = { "Dots", "Net", "Perls" };
            var stack2 = new Stack<string>(values);

            //Display the stack
            Console.WriteLine("---Stack Content---");
            foreach (string word in stack2) {
                Console.WriteLine(word);
            }

            //See if the stack contains "Perls"
            bool contains = stack2.Contains("Perls");
            Console.WriteLine("\n"+contains);
            Console.Read();
        }
    }
}
