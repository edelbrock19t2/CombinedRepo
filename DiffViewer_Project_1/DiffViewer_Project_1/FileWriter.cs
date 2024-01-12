using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffViewer_Project_1
{
    internal class FileWriter
    {
        public static void WriteData(string line, string fullPath)
        {
            using(StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(line.Trim());
            }
        }
    }
}
