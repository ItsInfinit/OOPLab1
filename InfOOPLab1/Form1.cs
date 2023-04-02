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
    }
}
