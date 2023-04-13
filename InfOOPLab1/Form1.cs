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
        
        //Task 1 "Calculate" button (button1)
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
        
        //Unused
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Task 2 "Calculate" button (button2)
        private void button2_Click(object sender, EventArgs e)
        {
            double a;
            double h;
            double s;
            double r;
            double R;
            try
            {
                a = Convert.ToDouble(textBox4.Text);
                h = Math.Sqrt(3) / 2 * a;
                s = Math.Sqrt(3) / 4 * Math.Pow(a, 2);
                r = Math.Sqrt(3) / 6 * a;
                R = Math.Sqrt(3) / 3 * a;
                textBox5.Text = Convert.ToString(h);
                textBox6.Text = Convert.ToString(s);
                textBox7.Text = Convert.ToString(r);
                textBox8.Text = Convert.ToString(R);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //Task 3 "Check" button (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string numberString = textBox9.Text;
                int last_digit = -10;
                bool pass = false;
                foreach (char c in numberString)
                {
                    int next_digit = int.Parse(Convert.ToString(c));
                    Console.WriteLine(next_digit);
                    Console.WriteLine(pass);
                    if (last_digit > next_digit)
                    {
                        pass = false;
                        break;
                    }
                    else
                    {
                        last_digit = next_digit;
                        pass = true;
                    }
                }
                label11.Text = Convert.ToString(pass);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //Task 4 "Calculate" button (button4)
        private void button4_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            double p;
            double s;
            try
            {
                a = Convert.ToDouble(textBox10.Text);
                b = Convert.ToDouble(textBox11.Text);
                c = Convert.ToDouble(textBox12.Text);
                if ((a + b > c) && (a + c > b) && (b + c > a))
                {
                    p = (a + b + c) / 2;
                    s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    textBox13.Text = Convert.ToString(s);
                }
                else
                {
                    MessageBox.Show("A triangle with this sides does not exist.");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }

        //Task 5 "Check" button (button5)
        private void button5_Click(object sender, EventArgs e)
        {
            int n;
            int count = 0;
            try
            {
                n = Convert.ToInt32(textBox14.Text);
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                    {
                        count++;
                    }
                }
                label18.Text = "There are " + count + " numbers that satisfy the condition";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String str = textBox15.Text;
            String[] words = str.Split(' ');
            String output ="";
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (word.Length > 0 && word[0] == word[word.Length - 1])
                {
                    output = output + (" " + word);
                }
            }
            if (output != "")
            {
                MessageBox.Show("Words that satisfy condition: \n" + output);
            }
            else
            {
                MessageBox.Show("There is no words that satisfy condition");
            }
        }
    }
}
