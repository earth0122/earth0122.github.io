using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_LoopWords
{
    internal class Program
    {  
        static void Main(string[] args)
        {   //和作業數字排序有點相關(Reverse) 
            //印出請輸入一段文字
            Console.WriteLine("請輸入一段文字:");
            //把輸入的值儲存在input裡
            string input = Console.ReadLine();
            //把剛剛string型別的input轉換成char的陣列儲存在char1裡面
            char[] char1 = input.ToCharArray();
            //把char1反轉並以char陣列儲存在char2裡面
            char[] char2 = char1.Reverse().ToArray();
            bool Right = true; //用布林值去判斷 true=回文
            //利用迴圈 來一一判斷char1 和 char2一不一樣
            for (int i = 0; i < char1.Length; i++)
            {
               //正反字元一樣 回文
                if (char1[i] == char2[i]) 
                {
                    Right = true;                    
                }
                //正反字元不一樣 不是回文
                else
                {
                    Right=false;
                    break;
                }
            }
            if (Right)
            {
                Console.WriteLine("是回文");
            }
            else
            {
                Console.WriteLine("不是回文");
            }
            Console.ReadLine();
        }
    }
}





