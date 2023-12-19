using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Window_App_11._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if(enableCheckbox.Checked == true)
            {
                if(labelToChange.Text == "Z prawej")
                {
                    labelToChange.Text = "Z lewej";
                    labelToChange.
                }
            }
        }

        private void enableCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
