using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorts
{
    class Program
    {
        static public int Partition(int[] numbers, int left, int right) {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
                while (numbers[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
            
        }
        static public void QuickSort_Recursive(int[] array, int left, int right) {
            //For recursion
            if (left < right) {
                int pivot = Partition(array, left, right);
                if (pivot > 1) {
                    QuickSort_Recursive(array, left, pivot);

                    if (pivot + 1 < right) {
                        QuickSort_Recursive(array, pivot+1, right);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            /*
            int[] number = { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = number.Length;

            //Sorting an array by using bubble sort
            /*
            for (int i = 1; i <= (numLength-1) && flag; i++) {
                flag = false;
                for (int j = 0; j< (numLength-1); j++) {
                    if (number[j + 1] < number[j])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            
            /**************
                Sorting an array by using bubble sort
         
            //Sorted array print
            foreach (int num in number) {
                Console.WriteLine(num);
            }
            */

            /*
                Quick sort
            */

            //Three steps: 
            //Divide: Rearrrange the elements and spliut the array into 2 sub arrays and element in between such that each element in the left subarray is less than or equal the middle element and each element in the right subarray is greater than or equal to the middle element
            //Conquer: Recusively sort the two subarrays 
            //Combine

            int[] numbers = { 3, 8, 7, 5, 2, 1, 3, 6, 4 };
            numbers = numbers.Distinct().ToArray();

            Console.WriteLine("QuickSort by Recursiive Method");

            QuickSort_Recursive(numbers, 0, numbers.Length-1);

            foreach (int num in numbers) {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
