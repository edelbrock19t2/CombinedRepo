using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_do_zaraadzania_wymowkami_1
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private string selectFolder = "";
        private bool formChanged = false;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectFolder;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                selectFolder = folderBrowserDialog1.SelectedPath;
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomExecuseButton.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateForm(bool changed)
        {
            if(!changed)
            {
                this.execuseTextBox.Text = currentExcuse.Description;
                this.wynikiTextBox.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;

                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }

                this.Text = "Program do Zarządzania wymówkami";
            }
            else
            {
                this.Text = "Program do zarządzania wymówkami*";
            }

            this.formChanged = changed;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(execuseTextBox.Text) || String.IsNullOrEmpty(wynikiTextBox.Text))
            {
                MessageBox.Show("Określ wymówkę i rezultat",
                    "Nie można zapisać pliku", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = selectFolder;
            saveFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.FileName = execuseTextBox.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Wymówka zapisana");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectFolder;
                openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
                saveFileDialog1.FileName = execuseTextBox.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();

                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                    "Bieżąca wymówka nie została zapisana. Czy kontynuować?",
                    "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }

        private void randomExecuseButton_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                currentExcuse = new Excuse(random, selectFolder);
                UpdateForm(false);
            }
        }

        private void execuseTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = execuseTextBox.Text;
            UpdateForm(true);
        }

        private void wynikiTextBox_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = wynikiTextBox.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }
    }
}
