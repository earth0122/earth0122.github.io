using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業4_九九乘法表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //乘法表要弄2個迴圈 x*y=z，首先要跑x第1次迴圈，讓裡面的y迴圈從1跑到9，由於不用換行，所以用write
            //後面y跑到9後，用WriteLine讓他換行，換完行後，跑外面的x迴圈，直到x的迴圈跑完9的時後結束
            
            for (int x = 1; x < 10 ; x++ )
            {

                for (int y = 1; y < 10 ; y++)
                {
                    Console.Write($"{ x }*{ y }={ x * y } ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }


    }
}
