using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 單字計算器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出請輸入一個英文句子
            Console.WriteLine("請輸入一個英文句子");
            //把使用者輸入的值，儲存到sentese
            string sentese = Console.ReadLine();
            //把sentese分割，儲存到strings
            string[] strings = sentese.Split(' ');
            //印出(sentese)也就是使用者輸入句子一共有幾個字
            Console.WriteLine($"{sentese}一共有{strings.Length}字");
            
                        
            Console.ReadLine();

        }
    }
}

