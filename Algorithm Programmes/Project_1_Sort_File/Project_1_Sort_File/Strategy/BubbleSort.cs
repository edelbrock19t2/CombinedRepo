using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Sort_File.Strategy
{
    internal class BubbleSort : SortStrategy
    {
        private Stopwatch stopwatch;

        public BubbleSort()
        {
            stopwatch = new Stopwatch();
        }

        public virtual int[] provideSort(int[] array)
        {
            stopwatch.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    //array[i + 1] = array[i];
                    array[i + 1] = temp;
                }
            }
            stopwatch.Stop();
            //Console.WriteLine($"Bubble sort time(int): {stopwatch.ElapsedMilliseconds} milliseconds");

            return array;
        }

        public virtual string[] provideSort(string[] array)
        {
            String temp;

            stopwatch.Start();
            // Sorting strings using bubble sort
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            stopwatch.Stop();


            //Console.WriteLine($"Bubble sort time(strings): {stopwatch.ElapsedMilliseconds} milliseconds");

            return array;
        }
    }
}
