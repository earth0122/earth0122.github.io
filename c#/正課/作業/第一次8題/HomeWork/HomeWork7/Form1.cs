using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string input = textBox1.Text;
            int year = int.Parse(input);
            int sunday = CalculateDaysV1(year, DayOfWeek.Sunday);
            int saturday = CalculateDaysV1(year, DayOfWeek.Saturday);
            MessageBox.Show = ($"{year}年，星期六 {saturday} 天，星期日 {sunday} 天");
        }

        private int CalculateDaysV1(int year, DayOfWeek dayOfWeek)
        {
            //2020, Sat.
            int baseDays = 52;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);

            if (!DateTime.IsLeapYear(year))
            //if (firstDay.DayOfWeek == lastDay.DayOfWeek)
            //if(lastDay.DayOfYear != 366)
            {
                if (firstDay.DayOfWeek == dayOfWeek)
                {
                    baseDays++;
                }
            }
            else
            {
                if (firstDay.DayOfWeek == dayOfWeek || lastDay.DayOfWeek == dayOfWeek)
                {
                    baseDays++;
                }
            }

            return baseDays;
        }

        private int CalculateDaysV2(int year, DayOfWeek dayOfWeek)
        {

            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            int baseDays = 52;

            if (firstDay.DayOfWeek == dayOfWeek || lastDay.DayOfWeek == dayOfWeek)
            {
                baseDays++;
            }

            return baseDays;
        }

    }

}

