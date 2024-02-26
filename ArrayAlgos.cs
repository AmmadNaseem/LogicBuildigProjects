using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LogicBuildigProjects
{
    public class ArrayAlgos
    {
        void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        public int[] waveArray(int[] arr)
        {
            //  first element is larger than the second and the same thing is repeated again and again.
            //  large element – small element-large element -small element and so on .
            //Input:  arr[] = {10, 5, 6, 3, 2, 20, 100, 80}
            //Output: arr[] = { 10, 5, 6, 2, 20, 3, 100, 80 }
            int size = arr.Length;
            Array.Sort(arr);
       
            for (int i = 0; i < size-1; i=i+2)
            {
                if (arr[i] < arr[i + 1])
                {
                    swap(arr, i, i + 1);
                }
            }
            return arr;
        }
     

        public int[] optimizeWaveArray(int[] arr)
        {
            // Input: arr[] = { 10, 5, 6, 3, 2, 20, 100, 80 }
            // Output: arr[] = { 10, 5, 6, 2, 20, 3, 100, 80 }
            //The idea is based on the fact that if we make sure that all even positioned(at index 0, 2, 4, ..)
            //elements are greater than their adjacent odd elements, we don’t need to worry about oddly positioned elements. 

            int size = arr.Length;

            for (int i = 0; i < size - 1; i = i + 2)
            {
                //If the current element is smaller than the previous odd element, swap the previous and current. 
                if (i>0 && arr[i] < arr[i - 1])
                {
                    swap(arr, i, i - 1);
                }
                //If the current element is smaller than the next odd element, swap next and current.
                if (i < size - 1 && arr[i] < arr[i + 1])
                {
                    swap(arr, i, i + 1);
                }
            }
            return arr;
          
        }

        public void findSubArrayWithGivenSum(int[] arr, int sum)
        {
            // Input: arr[] = { 1, 4, 20, 3, 10, 5 }, sum = 33
            // Output: Sum found between indexes 2 and 4
            // Explanation: Sum of elements between indices 2 and 4 is 20 + 3 + 10 = 33
      
            for (int i = 0; i < arr.Length-1; i++)
            {
                int arraySum = 0;
                for (int j=i+1;j<arr.Length-1;j++)
                {
           
                    if (arraySum == 0)
                    {
                        arraySum = arr[i] + arr[j];
                    }
                    else
                    {
                        arraySum = arraySum + arr[j];
                    }

                    if (arraySum == sum)
                    {
                        Console.WriteLine($"Sum found between indexes {i} and  {j}");
                        break;
                    }
                    else if (arraySum > sum)
                    {
                        j = arr.Length;
                    }
                
                }
            }
            Console.WriteLine("No subarray found");

        }
    }
}
