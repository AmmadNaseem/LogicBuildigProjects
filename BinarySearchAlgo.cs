using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuildigProjects
{
    public class BinarySearchAlgo
    {
        public bool BinarySearchWithoutRecursion(int[] arr, int key)
        {
            int size = arr.Length;
            int mid = size / 2;
            if (arr[mid] == key)
            {
                return true;
            }
            else if (arr[mid] < key)
            {
                for (int i = mid + 1; i < size; i++)
                {
                    if (arr[i] == key)
                    {
                        return true;
                    }
                }
            }
            else if (arr[mid] > key)
            {
                for (int i = 0; i < mid; i++)
                {
                    if (arr[i] == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool BinarySearchWithRecursion(int[] arr, int key)
        {
            return BinarySearchRecursive(arr, key, 0, arr.Length - 1);
        }

        private bool BinarySearchRecursive(int[] arr, int key, int left, int right)
        {
            // 1,3,4
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == key)
                {
                    return true;
                }
                else if (arr[mid] < key)
                {
                    return BinarySearchRecursive(arr, key, mid + 1, right); // Search in the right half
                }
                else // arr[mid] > key
                {
                    return BinarySearchRecursive(arr, key, left, mid - 1); // Search in the left half
                }
            }

            return false; // Key not found
        }

    }
}
