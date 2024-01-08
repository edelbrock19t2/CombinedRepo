using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Sort_File.Strategy
{
    internal class QuickSort : SortStrategy
    {

        public virtual int[] provideSort(int[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }

        private int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);
            return array;
        }

        public virtual string[] provideSort(string[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }

        public string[] SortArray(string[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                SortArray(arr, low, pi - 1);
                SortArray(arr, pi + 1, high);
            }

            return arr;
        }

        public int Partition(string[] arr, int low, int high)
        {
            string pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (String.Compare(arr[j], pivot) < 0)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}
