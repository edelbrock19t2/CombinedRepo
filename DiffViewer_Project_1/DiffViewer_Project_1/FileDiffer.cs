using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffViewer_Project_1
{
    internal class FileDiffer
    {

        public string FisrtFileName { get; set; }
        public string SecondFileName { get; set; }

        private string FullFistFilePath;
        private string FullSecondFilePath;

        private List<string> MainFileStrings;
        private List<string> SubFileStrings;
        public List<int> NumberOfLines;

        public FileDiffer(string fisrtFileName, string secondFileName)
        {
            FisrtFileName = fisrtFileName;
            SecondFileName = secondFileName;

            FullFistFilePath = SearchForAFile(fisrtFileName);
            FullSecondFilePath = SearchForAFile(secondFileName);

            MainFileStrings = new List<string>();
            SubFileStrings = new List<string>();
            NumberOfLines = new List<int>();
        }

/*        public FileDiffer(string FullFistFilePath, string FullSecondFilePath)
        {
            this.FullFistFilePath = FullFistFilePath;
            this.FullSecondFilePath = FullSecondFilePath;

            MainFileStrings = new List<string>();
            SubFileStrings = new List<string>();
            NumberOfLines = new List<int>();
        }
*/
        public List<int> DiffTwoFiles()
        {
            ReadMainFile(SearchForAFile(FisrtFileName));
            ReadSubFile(SearchForAFile(SecondFileName));


            Console.WriteLine("Count of rows in file 1: " + CountRowsInFile(FullFistFilePath));
            Console.WriteLine("Count of rows in file 2: " + CountRowsInFile(FullSecondFilePath));


            return CompareTwoFilesStrings(MainFileStrings, SubFileStrings);
        }

        public List<int> CompareTwoFilesStrings(List<string> mainFileStrings, List<string> subFileStrings)
        {
            NumberOfLines.Clear();
            if (mainFileStrings.Count() > subFileStrings.Count())
            {
                for (int i = 0; i < subFileStrings.Count(); i++)
                {
                    if (mainFileStrings.ElementAt(i).ToString().Equals(subFileStrings.ElementAt(i).ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        NumberOfLines.Add(i);
                    }
                }

                for (int i = subFileStrings.Count() - 1; i < mainFileStrings.Count() - 1; i++) NumberOfLines.Add(i + 1);

            }
            else if (mainFileStrings.Count() == subFileStrings.Count())
            {
                for (int i = 0; i < mainFileStrings.Count(); i++)
                {
                    if (mainFileStrings.ElementAt(i).ToString().Equals(subFileStrings.ElementAt(i).ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        NumberOfLines.Add(i);
                    }
                }
            }
            else if (mainFileStrings.Count() < subFileStrings.Count())
            {

                for (int i = 0; i < mainFileStrings.Count(); i++)
                {
                    if (subFileStrings.ElementAt(i).ToString().Equals(mainFileStrings.ElementAt(i).ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        NumberOfLines.Add(i);
                    }
                }

                for (int i = mainFileStrings.Count() - 1; i < subFileStrings.Count() - 1; i++) NumberOfLines.Add(i + 1);
            }


            return NumberOfLines;
        }

        public void ReadMainFile(string filePath)
        {
            string line = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    MainFileStrings.Add(line);
                    line += line;
                }
            }
        }

        public void ReadSubFile(string filePath)
        {
            string line = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    SubFileStrings.Add(line);
                    line += line;
                }
            }
        }

        private int CountRowsInFile(string filePath)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }

        public string SearchForAFile(string fileName)
        {
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"C:\Users\Xopero\Desktop");
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + fileName + ".*");

            string fullFillePath = "";
            foreach (FileInfo foundFile in filesInDir)
            {
                fullFillePath = foundFile.FullName;
            }

            if (fullFillePath == "")
            {
                MessageBox.Show("Make sure, you're placed your files in the Desktop folder", "File with name: " + fileName + " doesn't exists");
                return "1";
            }

            return fullFillePath;
        }
    }
}

