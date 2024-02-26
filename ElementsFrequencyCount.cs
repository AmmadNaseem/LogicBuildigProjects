using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuildigProjects
{
    public class ElementsFrequencyCount
    {
        public  void frequencyCount(int[] arr)
        {

            int count;
            int size = arr.Length;

            Console.WriteLine("Before Finding Frequency of Numbers:");

            for (int d = 0; d < size; d++)
            {
                Console.Write(arr[d] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == -1)
                {
                    continue;
                }
                count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[j] = -1;
                        count++;
                    }
                }
                if (arr[i] != -1)
                {
                    Console.WriteLine(arr[i] + " is " + count + " time(s)");
                }

            }

        

    }

    }
}
