using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {   //印出輸入層數(1~9)
            Console.Write("輸入層數(1~9):");
            //把輸入的值string轉為int儲存在input裡面
            int input = int.Parse(Console.ReadLine());
            //利用迴圈 跑input層 也就是輸入的層數
            for (int i = 0; i <= input; i++)
            {   
                //利用迴圈 跑數字前面空格的數量
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                //利用迴圈 跑每層數字出現的次數      //ex input=5 i=0
                //                                //(int k(5) = input(5); k(5) > i(0); k--)
                for (int k = input; k > i; k--)   //Console.Write(input(5)-i(0)) 寫第一個5        做完後k--進迴圈 判斷k(4)>i(0)
                {                                 //(int k(4) = input(5);k(4)>i(0);k--)
                    Console.Write(input-i);       //Console.Write(input(5)-i(0)) 寫第二個55        做完後k--進迴圈判斷k(3)>i(0)  以此類推
                }
                Console.WriteLine();
            }
            Console.ReadLine(); 



        }
    }
}
