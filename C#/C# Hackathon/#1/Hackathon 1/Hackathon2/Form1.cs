using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            if (radioButton1.Checked)
            {
                // F = 9/5 * C + 32
                double f = double.Parse(textBox1.Text) * 9 / 5 + 32;            
                label1.Text = f.ToString();

            }
            else if (radioButton2.Checked)
            {
                double c = ((double.Parse(textBox1.Text)) - 32)*5/9 ;
                label1.Text = c.ToString();

            }
            else
            {
                MessageBox.Show("請選擇溫度轉換");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=String.Empty;
        }
    }
}
