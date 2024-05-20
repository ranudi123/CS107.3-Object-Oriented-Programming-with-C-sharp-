using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblsum_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtinput1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 + num2;

            lblsum.Text = "Result = " + sum.ToString();
        }

        private void btnsubscription_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtinput1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 - num2;

            lblsum.Text = "Result = " + sum.ToString();
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtinput1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 / num2;

            lblsum.Text = "Result = " + sum.ToString();
        }

        private void lblmultiplication_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtinput1.Text);
            int num2 = int.Parse(textBox2.Text);

            int sum = num1 * num2;

            lblsum.Text = "Result = " + sum.ToString();
        }
    }
}
