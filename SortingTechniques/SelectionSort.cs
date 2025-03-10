using System.ComponentModel;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Security.Cryptography;
using System;

namespace SortingTechniques
{
    public class SelectionSort
    {
        //Basic Problems:

        //        Sort an Array:
        //Implement selection sort to sort an array of integers in ascending order.
        //Example Input: [64, 25, 12, 22, 11]
        //Expected Output: [11, 12, 22, 25, 64]

        public static void BasicProblem1()
        {
            int[] arr = [64, 25, 12, 22, 11];

            Console.WriteLine("Array before sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("\nArray after sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        //        Reverse Order:
        //Modify your selection sort implementation to sort the array in descending order.
        //Example Input: [64, 25, 12, 22, 11]
        //Expected Output: [64, 25, 22, 12, 11]

        public static void BasicProblem2()
        {
            int[] arr = [64, 25, 12, 22, 11];

            Console.WriteLine("Array before sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int max = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[max])
                    {
                        max = j;
                    }
                }

                int temp = arr[max];
                arr[max] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("\nArray after sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        //        Sort Strings:
        //Use selection sort to sort an array of strings in lexicographical order.
        //Example Input: ["apple", "orange", "banana", "kiwi"]
        //Expected Output: ["apple", "banana", "kiwi", "orange"]

        public static void BasicProblem3()
        {
            string[] arr = ["apple", "orange", "banana", "kiwi"];

            Console.Write("Array before sorting: ");
            foreach (string str in arr)
            {
                Console.Write(str + " ");
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    string word1 = arr[min];
                    string word2 = arr[j];

                    int res = string.Compare(word1, word2);

                    if (res > 0)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    string temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }

            Console.Write("\nArray after sorting: ");
            foreach (string str in arr)
            {
                Console.Write(str + " ");
            }
        }

        //Intermediate Problems:

        //        Find k-th Smallest Element:
        //Use selection sort to find the k-th smallest element in an unsorted array.
        //Example Input: arr = [7, 10, 4, 3, 20, 15], k = 3
        //Expected Output: 7

        public static void IntermediateProblem1()
        {
            int[] arr = [7, 10, 4, 3, 20, 15];
            int k = 4;

            Console.WriteLine("Array: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            for (int i = 0; i < k; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
            Console.WriteLine("\nKth smallest element: " + arr[k - 1]);
        }

        //        Remove Duplicates and Sort:
        //Write a function that removes duplicate elements from an array, then sorts it using selection sort.
        //Example Input: [4, 2, 4, 1, 3, 2]
        //Expected Output: [1, 2, 3, 4]

        public static void IntermediateProblem2()
        {
            int[] arr = [4, 2, 4, 1, 3, 2];

            Console.WriteLine("Array before removing duplicates and sorting sorting: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr = arr.Where((val, idx) => idx != j).ToArray();
                        n = arr.Length;
                    }
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }

                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine("\nArray after removing duplicates and sorting: ");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        //        Sort Even and Odd Separately:
        //Split the array into even and odd numbers, sort each group using selection sort, and then merge them(even first, followed by odd).
        //Example Input: [1, 4, 3, 2, 6, 5]
        //Expected Output: [2, 4, 6, 1, 3, 5]

        public static void IntermediateProblem3()
        {
            int[] arr = [1, 4, 3, 2, 6, 5];

            Console.Write("Array before sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

                if (arr[i] % 2 == 0) even.Add(arr[i]);
                else odd.Add(arr[i]);
            }

            int n = 0;
            foreach (int i in even)
            {
                arr[n] = i;
                n++;
            }

            foreach (int i in odd)
            {
                arr[n] = i;
                n++;
            }

            Console.Write("\nArray after sorting: ");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }

        //        Advanced Problems:

        //        Sort 2D Array by Column:
        //Given a 2D array, sort it by a specific column using selection sort.
        //Example Input:
        //[[10, 2],
        // [5, 8],
        // [7, 1]]
        //Sort by Column 1 (0-indexed).
        //Expected Output:
        //[[5, 8],
        // [7, 1],
        // [10, 2]]

        public static void AdvancedProblem1()
        {
            int[][] arr = [[10, 2], [5, 8], [7, 1]];

            Console.Write("Array before swapping: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.Write("] ");
            }


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j][0] < arr[min][0])
                    {
                        min = j;
                    }
                }

                var temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Console.Write("Array after swapping: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.Write("] ");
            }
        }

        //       Find Minimum Number of Swaps:
        //Use a modified selection sort to calculate the minimum number of swaps needed to sort the array.
        //Example Input: [4, 3, 1, 2]
        //Expected Output: 3

        public static void AdvancedProblem2()
        {
            int[] arr = [4, 3, 1, 2];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;

                count++;
            }

            Console.WriteLine();
            Console.WriteLine(count);
        }

        // ----------------------------------------------------Need to code-----------------------------------
        //        Sort a Nearly Sorted Array:
        //Given an array where each element is at most k positions away from its target position, use selection sort to sort it efficiently.
        //Example Input: [3, 2, 1, 5, 4, 6, 8, 7], k = 2
        //Expected Output: [1, 2, 3, 4, 5, 6, 7, 8]

        public static void AdvancedProblem3()
        {
            int[] arr = [3, 2, 1, 5, 4, 6, 8, 7];
            int k = 2;

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = 0; i < arr.Length - 1 - k; i++)
            {
                int min = i;

                for (int j = i + 1; j < i + k; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}