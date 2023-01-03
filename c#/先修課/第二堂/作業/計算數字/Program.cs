using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 計算數字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出請輸入一串數字
            Console.WriteLine("請輸入一串數字");
            //把輸入的字串儲存在num
            string num = Console.ReadLine();
                    
            for (int i = 0; i < 10; i++)
            {
                //把i轉成string在轉換成char儲存到num1
                char num1 = char.Parse(i.ToString());
                //00123  分割0變成 0 0 123 減掉原本的123 所以要-1 利用這方式算出i出現幾次
                int count = num.Split(num1).Length - 1;
                //印出數字{}出現{}次
                Console.WriteLine($"數字{i}出現{count}次");
            }


            Console.ReadLine();
        }
    }
}
