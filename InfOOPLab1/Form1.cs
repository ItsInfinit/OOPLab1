using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfOOPLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += new EventHandler(button1_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Task 1 "Calculate" button
        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            double y;

            try 
            { 
                x = Convert.ToDouble(textBox1.Text); 
                y = Convert.ToDouble(textBox2.Text);

                double result = result = x * Math.Log(x) + (y / (Math.Cos(x) - (x / 3)));
                textBox3.Text = Convert.ToString(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Task 2 "Calculate" button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox4.Text);
                double num1 = Math.Sqrt(3.0) / 2.0 * x;
                double num2 = Math.Sqrt(3.0) / 4.0 * Math.Pow(x, 2.0);
                double num3 = Math.Sqrt(3.0) / 6.0 * x;
                double num4 = Math.Sqrt(3.0) / 3.0 * x;
                textBox5.Text = Convert.ToString(num1);
                textBox6.Text = Convert.ToString(num2);
                textBox7.Text = Convert.ToString(num3);
                textBox8.Text = Convert.ToString(num4);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message);
            }
        }
    }
}
