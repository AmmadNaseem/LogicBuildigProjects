using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuildigProjects
{
    public class SortingAlgos
    {
        public int[] SelectionSort(int[] arr)
        {
            int size = arr.Length;
            //==============SELECTION SORT=================
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public  int[] BubbleSort(int[] arr)
        {
            int size = arr.Length;
            //  =================BUBBLE SORT================
            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

      
        
        public  int[] InsertionSort(int[] arr)
        {
            int size = arr.Length;
            //=================INSERTION SORT================
            for (int i = 1; i < size; i++)
            {
                for (int j = i - 1; j >= 0 && arr[j] > arr[j + 1]; j--)
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
            return arr;
        }
    }
}
