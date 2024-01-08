using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Sort_File.Strategy
{
    internal class MergeSort : SortStrategy
    {

        public virtual int[] provideSort(int[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }

        private int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }

        private void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    array[k++] = leftTempArray[i++];
                }
                else
                {
                    array[k++] = rightTempArray[j++];
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        }

        public virtual string[] provideSort(string[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }

        public string[] SortArray(string[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                SortArray(arr, low, mid);
                SortArray(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }

            return arr;
        }

        public void Merge(string[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            string[] left = new string[n1];
            string[] right = new string[n2];
            Array.Copy(arr, low, left, 0, n1);
            Array.Copy(arr, mid + 1, right, 0, n2);
            int i = 0, j = 0;
            int k = low;
            while (i < n1 && j < n2)
            {
                if (String.Compare(left[i], right[j]) < 0)
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
