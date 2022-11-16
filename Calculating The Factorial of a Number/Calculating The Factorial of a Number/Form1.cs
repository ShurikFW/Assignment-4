using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_The_Factorial_of_a_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "please write the number";
            try
            {

            
            int i, fact = 1, number;
            number = int.Parse(textBox1.Text);
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            label2.Text = fact + "" ;
            }
            catch
            {
                MessageBox.Show(message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            textBox1.Text = " ";
        }
    }
}
