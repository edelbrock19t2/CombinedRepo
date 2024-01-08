﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Sort_File
{
    internal interface SortStrategy
    {
        int[] provideSort(int[] array);
        string[] provideSort(string[] array);
    }
}
