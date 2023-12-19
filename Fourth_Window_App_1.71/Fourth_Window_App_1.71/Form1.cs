using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fourth_Window_App_1._71
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 200;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 500, Name = "Joe" };
            bob = new Guy() { Cash = 400, Name = "Bob" };

            UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveGash(5);
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bank nie posiada takiej ilości pieniędzy");
            }
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " ma " + joe.Cash + " zł";
            bobsCashLabel.Text = bob.Name + " ma " + bob.Cash + " zł";
            bankCashLabel.Text = "Bank ma " + bank + " zł";
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveGash(5));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveGash(5));
            UpdateForm();
        }
    }
}
