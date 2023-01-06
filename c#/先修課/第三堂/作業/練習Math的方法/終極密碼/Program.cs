using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 終極密碼
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Random random = new Random();   ////設立一個新的隨機變數           
            int randow1 = random.Next(1, 101); //隨機變數的範圍在等於1 小於101內 並把值存在int型別的randow1
            int min = 1; //設定 int型別的min為1  也就是最小值
            int max = 100;//設定 int型別的max為100  也就是最大值
            while (true)
            {
                Console.WriteLine($"請輸入{min}-{max}之間的整數");//印出請輸入最小值-最大值之間的整數
                int number = int.Parse(Console.ReadLine());//使用者輸入的值為string 把他轉換成int並儲存在number
                if (number > randow1)  //如果輸入的值number>隨機變數出來的值randow1 把最大值替換掉                                       
                {                      //ex randow1=20 number=80 原本1-100會變成 1-80
                    max = number; 
                }
                else if (number < randow1) //如果輸入的值number<隨機變數出來的值randow1 把最小值替換掉 
                {                          ////ex randow1=50 number=30 原本1-100會變成 30-100
                    min = number;   
                }
                else                    //如果number=randow1 就用break 離開這個迴圈
                {
                    break;
                }
            }
            Console.WriteLine($"猜中了，答案是:{randow1}");
            Console.ReadLine();         
        }
    }
}
