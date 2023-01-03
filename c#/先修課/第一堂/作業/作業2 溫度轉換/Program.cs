using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業2_溫度轉換
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出請輸入華氏溫度
            Console.WriteLine("請輸入華氏溫度");
            //華氏到攝氏公式 c=(t-32)*5/9
            //把使用者輸入的華氏溫度根據公式換算，並且把換算出來的攝氏溫度帶入到c
            double c = (double.Parse(Console.ReadLine()) - 32) * 5 / 9;
            //把應對應的攝氏溫度印出來           
            Console.WriteLine($"應對應的攝氏溫度{c}");

            Console.ReadLine();


            //string strs = Console.ReadLine();
            //double f = double.Parse(strs);
            //double c = (f - 32) * 5 / 9;
            //Console.WriteLine($"應對應的攝氏溫度{c}");
            //Console.ReadLine();


        }
    }
}
