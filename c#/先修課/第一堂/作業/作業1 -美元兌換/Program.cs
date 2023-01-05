using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業1__美元兌換
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出新台幣數值
            Console.WriteLine("請輸入新台幣數值");
            //假設1美金=28新台幣
            //把使用者輸入新台幣的數值案照匯率換算成美金帶入到usd
            Double usd = Double.Parse(Console.ReadLine()) / 28;
            //把應對應的美金印出來
            Console.WriteLine($"應對應的美金{usd}");
            Console.ReadLine();


        }
    }
}