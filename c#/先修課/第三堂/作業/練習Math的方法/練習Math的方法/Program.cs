using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 練習Math的方法
{
    internal class Program
    {
        static void Main(string[] args)
        {   //四捨五入，無條件進位跟無條件捨去 https://dotblogs.com.tw/kevin_blog/2018/11/19/153011
            //印出輸入一個有3位以上小數的數字
            Console.WriteLine("輸入一個有3位以上小數的數字");
            //把輸入的值string轉換成double 並儲存在num裡面
            double num = double.Parse(Console.ReadLine());
            //利用無條件進位Math.Ceiling 把num的值處理完 並儲存到num1
            double num1 = Math.Ceiling(num);
            //利用無條件捨去Math.Floor把num的值處理完 並儲存到num2
            double num2 = Math.Floor(num);
            //利用四捨五入Math.Round 把num的值處理完 ,後面的數字代表後面第幾位 並儲存到num3
            double num3 = Math.Round(num,1, MidpointRounding.AwayFromZero);
           //利用字串插補 把值印出來
            Console.WriteLine($"{num}無條件進位到整數位:{num1}");
            Console.WriteLine($"{num}無條件捨去到整數位:{num2}");
            Console.WriteLine($"{num}四捨五入到小數位第1位:{num3}");
            Console.ReadLine();
        }
    }
}
