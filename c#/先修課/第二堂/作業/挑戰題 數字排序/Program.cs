using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 挑戰題_數字排序
{
    internal class Program
    {
        static void Main(string[] args)
        {   //挑戰題 數字從大到小排列，並用逗號組合
            Console.WriteLine("請輸入數字(用,分隔)");
            string num = Console.ReadLine();
            string[] numarray = num.Split(',');
            int[] ints = Array.ConvertAll(numarray, int.Parse);            
            Array.Sort(ints);
            //(Reverse 反轉) 原本由小到大 反轉後由大到小
            Array.Reverse(ints);
            //印出排序結果
            Console.WriteLine("排序結果");
            //利用string.Join來加,
            Console.WriteLine(string.Join(",",ints));            
            Console.ReadLine();          
            
            //利用foreach把陣列ints裡的值,一一抓出來放到item
            //foreach (int item in ints)
            //{
            //    Console.Write(item);
            //}
        }
    }
}
