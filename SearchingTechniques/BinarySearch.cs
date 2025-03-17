using System.Collections.Generic;
using System.Globalization;

namespace SearchingTechniques
{
    public class BinarySearch
    {
        //      Basic Problems

        //Find Element in Sorted Array:
        //Use binary search to find the index of a given element in a sorted array. 
        //Example Input: [1, 2, 3, 4, 5], target = 3 
        //Expected Output: 2 (index of 3)

        public static void BasciProblem1()
        {
            int[] arr = [1, 2, 3, 4, 5];
            int target = 3;

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int low = 0;
            int high = arr.Length - 1;

            int index = -1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    index = mid;
                    break;
                }

                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
            }

            Console.WriteLine("\n" + index);
        }

        //First Occurrence of Element
        //Use binary search to find the first occurrence of a given element in a sorted array with duplicates. 
        //Example Input: [1, 2, 2, 2, 3], target = 2 
        //Expected Output: 1 (index of first 2)

        public static void BasciProblem2()
        {
            int[] arr = [1, 2, 2, 2, 3];
            int target = 2;

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int low = 0;
            int high = arr.Length - 1;
            int index = -1;

            while (low <= high)
            {
                int mid = ((low + high) / 2);

                if (arr[mid] == target)
                {
                    index = mid;
                    break;
                }

                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
            }

            while (index - 1 > 0 && arr[index - 1] == target)
            {
                index--;
            }

            Console.WriteLine("\n" + index);
        }

        //      Intermediate Problems

        //Count Occurrences of Element
        //Use binary search to count the number of occurrences of a given element in a sorted array. 
        //Example Input: [1, 2, 2, 2, 3], target = 2 
        //Expected Output: 3 (number of 2s)

        public static void IntermediateProblems1()
        {
            int[] arr = [1, 2, 2, 2, 3];
            int target = 2;

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int low = 0;
            int high = arr.Length - 1;
            int index = -1;
            int count = 0;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                {
                    index = mid;
                    break;
                }

                else if (arr[mid] > target)
                {
                    high = mid - 1;
                }

                else
                {
                    low = mid + 1;
                }
            }

            low = index - 1;
            high = index + 1;

            if (index != -1) count++;

            while (low - 1 >= 0 || high + 1 < arr.Length)
            {
                if (arr[low] == target)
                {
                    count++;
                    low--;
                }

                if (arr[high] == target)
                {
                    count++;
                    high++;
                }
            }

            Console.WriteLine("\n" + count);
        }

        //Find Peak Element
        //Use binary search to find a peak element in an array. An element is a peak if it is greater than its neighbors. 
        //Example Input: [1, 3, 20, 4, 1, 0] 
        //Expected Output: 20 (a peak element)

        public static void IntermediateProblem2()
        {
            int[] arr = [1, 3, 20, 4, 1, 0];

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            int low = 1;
            int high = arr.Length - 2;
            int peakEle = -1;

            while (low <= high)
            {
                if (arr[low] > arr[low - 1] && arr[low] > arr[low + 1])
                {
                    peakEle = arr[low]; break;
                }

                else if (arr[high] > arr[high - 1] && arr[high] > arr[high + 1])
                {
                    peakEle = arr[high]; break;
                }

                low++;
                high--;
            }

            Console.WriteLine("\n" + peakEle);
        }

        //Square Root Calculation
        //Use binary search to find the square root of a given number up to a certain precision. 
        //Example Input: 16 
        //Expected Output: 4.0 (square root of 16)

        public static void IntermediateProblem3()
        {
            int n = 16;
            double precision = 0.1;

            double low = 0;
            double high = n;
            double mid = 0;

            while (high - low > precision)
            {
                mid = (high + low) / 2;

                if (mid * mid == n)
                {
                    break;
                }

                else if (mid * mid < n)
                {
                    low = mid;
                }

                else
                {
                    high = mid;
                }
            }

            Console.WriteLine(mid);
        }

        //      Advanced Problems

        //Search in Rotated Sorted Array
        //Use binary search to find an element in a rotated sorted array. 
        //Example Input: [4, 5, 6, 7, 0, 1, 2], target = 0 
        //Expected Output: 4 (index of 0)

        public static void AdvancedProblem1()
        {
        }

        //Median of Two Sorted Arrays
        //Use binary search to find the median of two sorted arrays. 
        //Example Input: [1, 3], [2] 
        //Expected Output: 2.0 (median of the two arrays)

        public static void AdvancedProblem2()
        {
        }

        //Find Minimum in Rotated Sorted Array
        //Use binary search to find the minimum element in a rotated sorted array. 
        //Example Input: [3, 4, 5, 1, 2] 
        //Expected Output: 1 (minimum element)

        public static void AdvancedProblem3()
        {
        }
    }
}