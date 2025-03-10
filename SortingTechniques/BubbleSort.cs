using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortingTechniques
{
    public class BubbleSort
    {
        //      Basic Problems

        //Sort an Array:
        //Write a program to sort an array of integers using bubble sort.
        //Example Input: [5, 1, 4, 2, 8]
        //Expected Output: [1, 2, 4, 5, 8]

        public static void BasicProblem1()
        {
            int[] arr = [5, 1, 4, 2, 8];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isSwapped = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isSwapped = true;
                    }
                }

                if (!isSwapped) break;
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Sort in Descending Order:
        //Modify your bubble sort implementation to sort the array in descending order.
        //Example Input: [5, 1, 4, 2, 8]
        //Expected Output: [8, 5, 4, 2, 1]

        public static void BasicProblem2()
        {
            int[] arr = [5, 1, 4, 2, 8];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isSwapped = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isSwapped |= true;
                    }
                }

                if (!isSwapped) break;
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Intermediate Problems

        //Count Swaps:
        //Write a bubble sort implementation that counts the number of swaps made while sorting the array.
        //Example Input: [4, 3, 1, 2]
        //Expected Output: 5 (number of swaps)

        public static void IntermediateProblem1()
        {
            int[] arr = [4, 3, 1, 2];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int swapsCount = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isSwapped = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        isSwapped = true;
                        swapsCount++;
                    }
                }

                if (!isSwapped) break;
            }

            Console.WriteLine();
            Console.Write(swapsCount);
        }

        //        Find Maximum in First Pass:
        //Use bubble sort logic to find the maximum element in the first pass without fully sorting the array.
        //Example Input: [3, 5, 1, 2, 4]
        //Expected Output: 5

        public static void IntermediateProblem2()
        {
            int[] arr = [3, 5, 1, 2, 4];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                break;
            }

            Console.WriteLine("\n" + arr[arr.Length - 1]);
        }

        //        Sort String Characters:
        //Sort the characters of a string alphabetically using bubble sort.
        //Example Input: "bubble"
        //Expected Output: "bbbelu"

        public static void IntermediateProblem3()
        {
            string str = "bubble";

            Console.WriteLine("String before sorting: " + str);

            char[] arr = str.ToCharArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                bool isSwapped = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        char temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped) break;
            }

            Console.WriteLine("String after sorting: " + new string(arr));
        }

        //        Sort Odd and Even Separately:
        //Sort odd numbers in ascending order and even numbers in descending order.
        //Example Input: [5, 2, 9, 1, 6, 8]
        //Expected Output: [1, 5, 9, 8, 6, 2]

        public static void IntermediateProblem4()
        {
            int[] arr = [5, 2, 9, 1, 6, 8];

            Console.Write("Array before sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

                if (arr[i] % 2 == 0) even.Add(arr[i]);
                else odd.Add(arr[i]);
            }

            int n = 0;

            for (int i = odd.Count - 1; i >= 0; i--)
            {
                arr[n] = odd[i];
                n++;
            }

            for (int i = 0; i < even.Count; i++)
            {
                arr[n] = even[i];
                n++;
            }

            Console.Write("\nArray after sorting: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //        Sort 2D Array by Rows:
        //Sort each row of a 2D array using bubble sort.
        //Example Input:
        //[[4, 2, 1],
        // [3, 5, 0],
        // [8, 7, 6]]
        //Expected Output:
        //[[1, 2, 4],
        // [0, 3, 5],
        // [6, 7, 8]]

        public static void AdvancedProblem1()
        {
            int[][] arr = [[4, 2, 1], [3, 5, 0], [8, 7, 6]];

            Console.Write("Array before sorting: ");
            for (int i = 0; i < arr.GetLength(0); i++)
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
                int[] subArr = arr[i];

                for (int j = subArr.Length - 1; j >= 0; j--)
                {
                    bool isSwapped = false;

                    for (int k = 0; k < j; k++)
                    {
                        if (subArr[k] > subArr[k + 1])
                        {
                            int temp = subArr[k];
                            subArr[k] = subArr[k + 1];
                            subArr[k + 1] = temp;

                            isSwapped = true;
                        }
                    }

                    if (!isSwapped) break;
                }
            }

            Console.Write("\nArray after sorting: ");
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

        // ----------------------------------------------------Need to code-----------------------------------
        //        Sort a Linked List:
        //Implement bubble sort to sort a singly linked list.
        //Example Input: [4-> 3-> 2-> 1]
        //Expected Output: [1-> 2-> 3-> 4]

        public static void AdvancedProblem2()
        {

        }
    }
}