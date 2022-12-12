using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomwWork7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = int.Parse(textBox1.Text);

            
            //一年有52.143周 = 52周+1天
            //閏年 
            int Saterday = 52;
            int Sunday = 52;
            //閏年
            
            bool IsLeapYear = true;
            //第一天
            DateTime firstDay = new DateTime(year, 1, 1);
            //如果是閏年的情況
            if (DateTime.IsLeapYear(year))
            {


                //第一天 而且是週五的話   閏年多1天
                if (firstDay.DayOfWeek == DayOfWeek.Friday)
                {
                    Saterday += 1;


                }
                //第一天 而且是週六的話   閏年多1天
                else if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    Saterday += 1;
                    Sunday += 1;
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                   
                    Sunday += 1;
                }
            }
            else 
            {
               
                if (firstDay.DayOfWeek == DayOfWeek.Saturday)
                {
                    Saterday += 1;
                   
                }
                else if (firstDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    Sunday += 1;

                }
            }

            MessageBox.Show($"星期六 {Saterday}天, 星期日 {Sunday} 天");
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
     /*   private int CalculateDaysV1(int year, DayOfWeek dayOfWeek)
        {
            int baseDays = 52;
            DateTime firstDay = new DateTime(year, 1, 1);
            if (!DateTime.IsLeapYear(year))
            {
                if (firstDay.DayOfWeek==dayOfWeek)
                {
                    baseDays++;
                }
            }
            else
            {
                DateTime lastDay = new DateTime(year, 12, 31);
            }
        }*/
    }

    }


