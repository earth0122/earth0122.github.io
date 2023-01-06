using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //利用for迴圈 i從1開始 到 小於101 迴圈跑完一次後 i+1 (這題跟之前作業判斷奇偶數和找數字有點相關)           
            for (int i = 1; i < 101; i++)
            {   //利用if判斷式 i/2的餘數==0 和i/3的餘數==0 => 共同倍數 印出金槍魚
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("金槍魚");
                }
                //i/2的餘數==0的 印出螃蟹
                else if (i % 2 == 0)
                {
                    Console.WriteLine("螃蟹");
                }
                //i/3的餘數==0的 印出章魚
                else if (i % 3 == 0)
                {
                    Console.WriteLine("章魚");
                }
                //印出剩餘的數字
                else
                {
                    Console.WriteLine(i);
                }                
            }
            Console.ReadLine();
        }
    }
}
