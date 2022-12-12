using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int year = int.Parse(textBox1.Text) +1911;
                int Saturday, Sunday;
                DateTime firstDay = new DateTime(year, 1, 1);
                DateTime lastDay = new DateTime(year + 1, 1, 1);
                Saturday = 0;
                Sunday = 0;
                for (DateTime date = firstDay; date < lastDay; date = date.AddDays(1.0))
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
    }
}
