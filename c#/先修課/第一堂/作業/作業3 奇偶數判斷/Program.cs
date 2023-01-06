using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業3_奇偶數判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {   //印出請輸入整數
            Console.WriteLine("請輸入整數");
            //將使用者輸入的數值，轉換成整數x
            int x = int.Parse(Console.ReadLine());
            //利用餘數區分 餘數0=偶數 
            if (x % 2 == 0)
            {
                Console.WriteLine("偶數");
            }
            //其餘奇數
            else
            {
                Console.WriteLine("奇數");
            }

            Console.ReadLine();
        }
    }
}


