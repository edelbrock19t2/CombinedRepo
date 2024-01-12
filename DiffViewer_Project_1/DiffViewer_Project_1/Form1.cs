using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace DiffViewer_Project_1
{
    public partial class Form1 : Form
    {

        private FileDiffer fileDiffer;
        private FileReader fileReader;
        private FileWriter fileWriter;

        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        public Form1()
        {
            InitializeComponent();
            AllocConsole();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximumSize = new Size(816, 512);
            this.MinimumSize = new Size(816, 512);
        }

        private void HighlightLines(string fileName, List<int> indexes)
        {
            secondFileText.Text = "";
            secondFileText.Text = fileReader.ReadFile(fileDiffer.SearchForAFile(fileName));
            string[] lines = secondFileText.Lines;
            secondFileText.Text = "";

            secondFileText.SelectAll();
            secondFileText.SelectionBackColor = Color.White;


            for(int i = 0; i < lines.Length; i++)
            {
                secondFileText.ForeColor = Color.Gray;
                if (indexes.Contains(i))
                {
                    secondFileText.SelectionStart = i;
                    secondFileText.SelectionLength = lines.ElementAt(i).Length;
                    secondFileText.SelectionBackColor = Color.Red;
                    secondFileText.Font = new Font("Cambria", 10);
                    
                    secondFileText.Text += $"{lines.ElementAt(i)}\t++highlight\n";

                }
                else
                {
                    secondFileText.Text += $"{lines.ElementAt(i)}\n";
                    secondFileText.Font = new Font("Lemonada", 10);
                    secondFileText.SelectionStart = i;
                    secondFileText.SelectionLength = lines.ElementAt(i).Length;
                    secondFileText.SelectionBackColor = Color.Gray;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileWriter.WriteData(firstFileText.Text, fileDiffer.SearchForAFile(firstFilePath_Input.Text));
            FileWriter.WriteData(firstFileText.Text, fileDiffer.SearchForAFile(secondFilePath_Input.Text));

            Console.WriteLine("---");
            Console.WriteLine("File " + firstFilePath_Input.Text + " has been written successfully");
            Console.WriteLine("File " + secondFilePath_Input.Text + " has been written successfully");
            Console.WriteLine("---");

            openAndDiffFiles();
        }

        private void openFIles_button_Click(object sender, EventArgs e)
        {
            openAndDiffFiles();
        }

        private void openAndDiffFiles()
        {

            if (firstFilePath_Input.Text != "" && secondFilePath_Input.Text != "")
            {
                fileDiffer = new FileDiffer(firstFilePath_Input.Text, secondFilePath_Input.Text);
                fileReader = new FileReader();

                firstFileText.Text = fileReader.ReadFile(fileDiffer.SearchForAFile(firstFilePath_Input.Text));
                firstFileText.Font = new Font("Roboto", 10);

               
                HighlightLines(secondFilePath_Input.Text, fileDiffer.DiffTwoFiles());
            }
            else
            {
                MessageBox.Show("Enter a file path");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void firstFilePath_Input_TextChanged(object sender, EventArgs e)
        {
        }

        private void secondFileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void secondFilePath_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void updateView_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FileWriter.WriteData(firstFileText.Text, fileDiffer.SearchForAFile(firstFilePath_Input.Text));
            
            openAndDiffFiles();
        }
    }
}
