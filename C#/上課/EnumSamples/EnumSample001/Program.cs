using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyWeekDays day = MyWeekDays.Sun;
            Console.WriteLine($"Today is {day}");
            if (day == MyWeekDays.Mon)
            {
                Console.WriteLine("Today is Monday");
            }
            else
            {
                Console.WriteLine("Today is not Monday");
            }
            //轉換回 int
            int i = (int)day;
            Console.WriteLine($"The value of {day} is {i}");

            Console.ReadLine();
        }
    }

    /// <summary>
    /// 自動從0開始
    /// </summary>
    public enum MyWeekDays
    {
        Sun,Mon,Tue,Wed,Thu,Fri,Sat
    }
    /// <summary>
    /// 設定從1開始
    /// </summary>
    public enum BrowserTypes
    {
        IE = 1, Edge,FireFox ,Chrom
    }

    /// <summary>
    /// 全部值手動設定
    /// </summary>
    public enum SwitchTypes
    {
        On =0 ,Off =1
    }

}
