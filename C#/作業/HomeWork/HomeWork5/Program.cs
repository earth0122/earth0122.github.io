using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("請輸入一個中華民國年份:");
            string yearStr = Console.ReadLine();
            int year = int.Parse(yearStr);
            bool IsLeapYear=true;

            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("是閏年");
            }
            else
            {
                Console.WriteLine("不是閏年");
            }
            Console.ReadLine();
        }
    }
}
