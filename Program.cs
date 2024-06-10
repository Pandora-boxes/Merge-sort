using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void MergeSort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i =0; i < mid; i++)
            {
                left[i] = array[i];
            }
            Console.WriteLine("\nLeft array: ");
            foreach (int number in left)
            {
                Console.Write("{0}, ",number);
            }

            for (int i=mid; i < array.Length; i++)
            {
                right[i -mid] = array[i];
            }
            Console.WriteLine("\nRight array: ");
            foreach (int number in right)
            {
                Console.Write("{0}, ", number);
            }


            MergeSort(left);
            MergeSort(right);

            Merge(array, left, right);
        }

        public static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while(i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }

            while(i < left.Length)
            {
                array[k++] = left[i++];
            }

            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0 ; i < numbers.Length ; i++)
            {
                Console.WriteLine("Enter the number at the {0} position", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("\nUnsorted array: ");
            foreach(int number in numbers)
            {
                Console.Write("{0}, ", number);
            }

            MergeSort(numbers);
            Console.WriteLine("\nSorted array:");
            foreach(int number in numbers)
            {
                Console.Write("{0}, ", number);
            }
            Console.ReadKey();

        }
    }
}
