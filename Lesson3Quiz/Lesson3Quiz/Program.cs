using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson3Quiz{
    class Program{
        public struct student { 
            public char [] answers;
        }
        static void Main(string[] args){
            student stu = new student();
            stu.answers = new char[7];
            string[] questions  = new string[]{
                "What is the first step in the ALM?:\n\nA.) Design\nB.) Testing\nC.) Requirements\nD.) Development","____ verifies the implemtation matches the requirements of the system:\n\nA.) Software Testing\nB.) Release Managment\nC.) Requirements\nD.) Testing", "Which of the following is a testing method:\n\nA.) White-box testing\nB.) Black-box testing\nC.) Both A and B\nD.) None of the above","Which testing level assures that no previous bugs were reintroduced upon current bug fix?:\n\nA.) System Testing\nB.) Regression\nC.) Acceptance Testing\nD.) Unit Testing","Are you able to randomly choose any item within an array?:\n\nA.) True\nB.) False","What is a common operation of a stack?:\n\nA.) Peek\nB.) Add\nC.) Remove\nD.) Enqueue","___ uses a series of comparison and swap operations to arrange the elements of a list in the correct order\n\nA.) Loop\nB.)BubbleSort\nC.) QuickSort\nD.) None of the above"};
            int i = 0;
            for(int i = 0 question in questions){
                Console.WriteLine(question);
                answers[i] = Console.ReadLine;
                Console.Clear();
            }

        }
    }
}
