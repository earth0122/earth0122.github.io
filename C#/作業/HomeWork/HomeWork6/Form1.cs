using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*namespace HomeWork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year =int.Parse(textBox1.Text);
            DateTime firstDay =new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year + 1, 1, 1);
            int Saturday = 0;
            int Sunday   = 0;
            for (DateTime date= firstDay; date < lastDay; date=date.AddDays(1.0))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    Saturday++;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Sunday++;
                }
            }
            MessageBox.Show($"星期六{Saturday}天,星期日{Sunday}天");
        }
    }
}*/
namespace HomeWork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);
            int Saturday, Sunday;
            NewMethod(year, out Saturday, out Sunday);
            MessageBox.Show($"星期六{Saturday}天,星期日{Sunday}天");
        }

        private static void NewMethod(int year, out int Saturday, out int Sunday)
        {
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year + 1, 1, 1);
            Saturday = 0;
            Sunday = 0;
            for (DateTime date = firstDay; date < lastDay; date = date.AddDays(1.0))./
            {
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    Saturday++;
                }
                else if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    Sunday++;
                }
            }
        }
    }
}

