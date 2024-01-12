using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiffViewer_Project_1
{
    internal class FileReader
    {

        public FileReader()
        {
        }

        public string ReadFile(string filePath)
        {
            string result = "";
            using(StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    result += line + "\n";
                }
            }

            return result;
        }
    }
}
