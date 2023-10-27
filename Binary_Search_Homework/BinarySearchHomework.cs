﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            while (end >= start)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;


                if (arr[mid1] == key)
                    return mid1;

                if (arr[mid2] == key)
                    return mid2;

                if (key < arr[mid1])
                {
                    end = mid1 - 1;
                }
                else if (key > arr[mid2])
                {
                    start = mid2 + 1;
                }
                else
                {
                    start = mid1 + 1;
                    end = mid2 - 1;
                }

            }





            return -1;
        }




        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            if (is_first)
            {
                if (start > end)
                    return -1;

                int mid = start + (end - start) / 2;

                if (arr[mid] < key)
                    return BinarySearchForCalculatingRepeated(arr, key, true, mid + 1, end);

                if (arr[mid] > key)
                    return BinarySearchForCalculatingRepeated(arr, key, true, start, mid - 1);

                if (mid == 0 || arr[mid - 1] != key)
                    return mid;

                return BinarySearchForCalculatingRepeated(arr, key, true, start, mid - 1);

            }
            else
            {
                if (start > end)
                {
                    return -1;
                }
                int mid = start + (end - start) / 2;
                if (arr[mid] < key)
                    return BinarySearchForCalculatingRepeated(arr, key, false, mid + 1, end);

                if (arr[mid] > key)
                    return BinarySearchForCalculatingRepeated(arr, key, false, start, mid - 1);

                if (mid == arr.Length - 1 || arr[mid + 1] != key)
                    return mid;


                return BinarySearchForCalculatingRepeated(arr, key, false, mid + 1, end);
            }

        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length - 1);
            int secound = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length - 1);
            if (first != -1)
            {
                return secound - first + 1;
            }
            else
            {
                return -1;
            }

        }
    }
}
