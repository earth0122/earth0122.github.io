using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數字排序問題
{
    internal class Program
    {
        static void Main(string[] args)
        {   //第一題輸入要排序的數字，用逗號分隔，顯示從小到大的排序結果
            //印出請輸入數字(用,分隔)
            Console.WriteLine("請輸入數字(用,分隔)");
            //把使用者輸入的字串,儲存到num
            string num = Console.ReadLine();
            //設定一個字串的陣列 numarry 並且把num分割後儲存進去
            string[] numarray = num.Split(',');
            //ConvertAll https://dotblogs.com.tw/kyleshen/2013/05/28/105009 
            //將原本string陣列的numarray轉換成int的陣列 並儲存於ints          
            int[] ints = Array.ConvertAll(numarray, int.Parse);
            //印出排序結果
            Console.WriteLine("排序結果");
            //利用 array.sort來排序(ints)由小到大
            Array.Sort(ints);
            //排序完後 利用foreach把陣列ints裡的值,一一抓出來放到item
            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
