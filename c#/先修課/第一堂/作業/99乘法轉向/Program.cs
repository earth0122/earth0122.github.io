using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99乘法轉向
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //藉由改變{y}*{x}的順序，可以讓99乘法達成轉向
            //首先要跑x第1次迴圈，讓裡面的y迴圈從1跑到9，由於不用換行，所以用write
            //後面y跑到9後，用WriteLine讓他換行，換完行後，跑外面的x迴圈，直到x的迴圈跑完9的時後結束
            //
            for (int x = 1; x < 10; x++)
            {

                for (int y = 1; y < 10; y++)
                {
                    Console.Write($"{y}*{x}={x * y}\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
