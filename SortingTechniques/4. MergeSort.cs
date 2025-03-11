using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortingTechniques
{
    public class MergeSort
    {
        //      Basic problems

        //Simple Array Sorting:
        //Sort an array of integers in ascending order using merge sort. 
        //Example Input: [5, 3, 8, 6, 4] 
        //Expected Output: [3, 4, 5, 6, 8]

        public static void BasicProblem1()
        {
            int[] arr = [5, 3, 8, 6, 4];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            MergeSort.MergeSortAlgo1(arr, 0, arr.Length - 1);

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void MergeSortAlgo1(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int mid = (low + high) / 2;

            MergeSort.MergeSortAlgo1(arr, low, mid);
            MergeSort.MergeSortAlgo1(arr, mid + 1, high);

            MergeSort.SortArray1(arr, low, mid, high);
        }

        public static void SortArray1(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();

            int left = low;
            int right = mid + 1;

            while (left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }

            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }

        //Sort Strings
        //Use merge sort to sort an array of strings alphabetically. 
        //Example Input: ["apple", "orange", "banana", "grape"] 
        //Expected Output: ["apple", "banana", "grape", "orange"]

        public static void BasicProblem2()
        {
            string[] arr = ["apple", "orange", "banana", "grape"];

            Console.Write("Array before sorting: ");
            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }

            MergeSort.MergeSortAlgo2(arr, 0, arr.Length - 1);

            Console.Write("\nArray before sorting: ");
            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void MergeSortAlgo2(string[] arr, int low, int high)
        {
            if (low >= high) return;

            int mid = (low + high) / 2;

            MergeSort.MergeSortAlgo2(arr, low, mid);
            MergeSort.MergeSortAlgo2(arr, mid + 1, high);

            MergeSort.SortArray2(arr, low, mid, high);
        }

        public static void SortArray2(string[] arr, int low, int mid, int high)
        {
            List<string> temp = new List<string>();

            int left = low;
            int right = mid + 1;

            while (left <= mid && right <= high)
            {
                string word1 = arr[left];
                string word2 = arr[right];

                int res = string.Compare(word1, word2);

                if (res <= 0)
                {
                    temp.Add(word1);
                    left++;
                }
                else
                {
                    temp.Add(word2);
                    right++;
                }
            }

            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }

            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }

        //      Intermediate problems

        //Kth Smallest Element
        //Use merge sort to find the Kth smallest element in an unsorted array. 
        //Example Input: [7, 10, 4, 3, 20, 15], k = 3 
        //Expected Output: 7 (3rd smallest element)

        public static void IntermediateProblem1()
        {
            int[] arr = [7, 10, 4, 3, 20, 15];
            int k = 3;

            Console.Write("Array before sorting: ");

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            MergeSort.MergeSortAlgo3(arr, 0, arr.Length - 1);

            Console.WriteLine("\n" + arr[k - 1]);
        }

        public static void MergeSortAlgo3(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int mid = (low + high) / 2;

            MergeSort.MergeSortAlgo3(arr, low, mid);
            MergeSort.MergeSortAlgo3(arr, mid + 1, high);

            MergeSort.SortArray3(arr, low, mid, high);
        }

        public static void SortArray3(int[] arr, int low, int mid, int high)
        {
            List<int> temp = new List<int>();

            int left = low;
            int right = mid + 1;

            while (left <= mid && right <= high)
            {
                if (arr[left] <= arr[right])
                {
                    temp.Add(arr[left]);
                    left++;
                }
                else
                {
                    temp.Add(arr[right]);
                    right++;
                }
            }

            while (left <= mid)
            {
                temp.Add(arr[left]);
                left++;
            }

            while (right <= high)
            {
                temp.Add(arr[right]);
                right++;
            }

            for (int i = low; i <= high; i++)
            {
                arr[i] = temp[i - low];
            }
        }

        // ----------------------------------------------------Need to code-----------------------------------
        //Sorting Linked List
        //Implement merge sort to sort a singly linked list. 
        //Example Input: 4 -> 2 -> 1 -> 3 
        //Expected Output: 1 -> 2 -> 3 -> 4

        public static void IntermediateProblem2()
        {

        }

        //      Advanced Problems

        // ----------------------------------------------------Need to code-----------------------------------
        //Merge K Sorted Arrays
        //Given K sorted arrays, merge them into a single sorted array using a modified merge sort approach. 
        //Example Input: [[1, 4, 7], [2, 5, 8], [3, 6, 9]] 
        //Expected Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]

        public static void AdvancedProblem1()
        {

        }
    }
}
