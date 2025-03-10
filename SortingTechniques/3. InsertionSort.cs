using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortingTechniques
{
    public class InsertionSort
    {
        //        Basic Problems

        //Sort an Array:
        //Implement insertion sort to sort an array of integers in ascending order.
        //Example Input: [5, 3, 4, 1, 2]
        //Expected Output: [1, 2, 3, 4, 5]

        public static void BasicProblem1()
        {
            int[] arr = [5, 3, 4, 1, 2];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;
                }
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Sort in Descending Order:
        //Modify your insertion sort implementation to sort an array in descending order.
        //Example Input: [7, 2, 8, 6, 4]
        //Expected Output: [8, 7, 6, 4, 2]

        public static void BasicProblem2()
        {
            int[] arr = [7, 2, 8, 6, 4];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j - 1] < arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;
                }
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Sort Strings Alphabetically:
        //Use insertion sort to sort an array of strings in lexicographical order.
        //Example Input: ["zebra", "apple", "mango", "banana"]
        //Expected Output: ["apple", "banana", "mango", "zebra"]

        public static void BasicProblem3()
        {
            string[] arr = ["zebra", "apple", "mango", "banana"];

            Console.Write("Array before sorting: ");
            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && string.Compare(arr[j - 1], arr[j]) > 0)
                {
                    string temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;
                }
            }

            Console.Write("\nArray after sorting: ");
            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Count Shifts(or Moves):

        //Implement insertion sort and count how many shifts(or moves) are performed while sorting.
        //Example Input: [4, 3, 2, 1]
        //Expected Output: 3 (number of shifts)

        public static void IntermediateProblem1()
        {
            int[] arr = [4, 3, 2, 1];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    count++;
                }
            }

            Console.WriteLine("\n" + count);
        }

        //        Sort Subarray:
        //Sort only a portion of the array(subarray) using insertion sort.
        //Example Input: [9, 8, 4, 5, 2], Sort indices 1 to 3.
        //Expected Output: [9, 4, 5, 8, 2]

        public static void IntermediateProblem2()
        {
            int[] arr = [9, 8, 4, 5, 2];
            int min = 1;
            int max = 3;

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = min; i < max; i++)
            {
                int j = i;

                while (j > min && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;
                }
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Find K-th Largest Element:
        //Use insertion sort logic to find the k-th largest element without fully sorting the array.
        //Example Input: [5, 3, 8, 6, 4], k = 2
        //Expected Output: 6 (2nd largest)

        public static void IntermediateProblem3()
        {
            int[] arr = [5, 3, 8, 6, 4];
            int k = 2;

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int kMax = 0;
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;

                    if (j == arr.Length - 1 - k)
                    {
                        kMax = arr[j];
                        isFound = true;
                        break;
                    }
                }

                if (isFound) break;
            }

            Console.WriteLine("\n" + kMax);
        }

        public static void AdvancedProblem1()
        {
            int[][] arr = [[10, 2], [5, 8], [7, 1]];

            Console.Write("Array before sorting: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.Write("] ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;

                while (j > 0 && arr[i - 1][0] > arr[i][0])
                {
                    int[] temp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = temp;

                    j--;
                }
            }

            Console.Write("\nArray after sorting: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("[");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.Write("] ");
            }
        }
    }
}
