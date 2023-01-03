using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //印出輸入層數(1~9)
    //        Console.Write("輸入層數(1~9):");
    //        //把輸入的值string轉為int儲存在input裡面
    //        int input = int.Parse(Console.ReadLine());
    //        //利用迴圈 跑input層 也就是輸入的層數
    //        for (int i = 1; i <= input; i++) //階層
    //        {
    //            for (int j = 0; j<i  ; j++)   //數字幾次                       //1???
    //            {                                                             //22??
    //                Console.Write(i);                                         //333?
    //            }                                                             //4444
    //            //for (int k = input; k >i ; k--) //正的可以不用空格
    //            //{
    //            //    Console.Write(" ");
    //            //}
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入");
            int input = int.Parse(Console.ReadLine());
            for (int i = input; i > 0; i--)
            {
                for (int k = 0; k < input - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
