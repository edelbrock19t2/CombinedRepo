using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Sort_File
{
    internal class Sortener
    {
        public int SortId { get; set; }
       // public T ArrayToSort { get; set; }
        public string FileType { get; set; }

        public SortStrategy sortStrategy {  get; set; }

        public Sortener() { }

        public Sortener(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public int[] sortArray(int[] array)
        {
            return sortStrategy.provideSort(array);
        }

        public string[] sortArray(string[] array)
        {
            return sortStrategy.provideSort(array);
        }
    }
}
