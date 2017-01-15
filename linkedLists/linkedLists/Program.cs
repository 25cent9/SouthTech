using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //In terms of memory usaage, the linked lists is often less efficient than a properly-sized arra or list of the element
            //Each node in the linked list will require a seperate root in the garbage collector. In an array or list, namay references are stored in a single block on the managed heap togetherm redcint the work required for garbage collection 
            // Linked list tyoe is the time required for inserting or removing elements in the collection. In a list or array, to 


            //Create a  new linked list object instance
            LinkedList<string> linked = new LinkedList<string>();

            //Use AddLast method to add elements at the end
            linked.AddLast("Cat");
            linked.AddLast("Dog");
            linked.AddLast("Man");
            linked.AddLast("First");

            //Loop through the linked list with the foreach
            foreach (var animal in linked) {
                Console.WriteLine(animal);
            }

            //Insert node before the second node
            LinkedListNode<string> node = linked.Find("Man");
            linked.AddBefore(node, "Inserted before");

            Console.WriteLine("\nAfter insert Before:");
            foreach (var animal in linked)
            {
                Console.WriteLine(animal);
            }

            //Add after
            LinkedListNode < string > node2 = linked.Find("Cat");
            linked.AddAfter(node2, "Inserted after:");
            Console.WriteLine("\nAdd After:");
            foreach (var animal in linked)
            {
                Console.WriteLine(animal);
            }

            //Remove
            linked.Remove("Cat");
            Console.WriteLine("\nCat removed:");
            foreach (var animal in linked)
            {
                Console.WriteLine(animal);
            }
            GC.Collect();

            linked.RemoveFirst();
            linked.RemoveLast();

            Console.WriteLine("\nRemoved first and last:");
            foreach (var animal in linked)
            {
                Console.WriteLine(animal);
            }
            GC.Collect();
            Console.Read();

        }
    }
}
