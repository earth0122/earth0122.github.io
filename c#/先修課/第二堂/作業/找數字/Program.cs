using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 找數字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出1-50之間非3的倍數或非5的倍數的數字
            //利用for迴圈設定i=1 跑到50
            for (int i = 1; i < 51; i++)
            {
                // ||是兩者只要一個對 就對 所以不能用 ex 6 9 12... 不符合前面%3的 但符合後面%5的，所以要用&& 
                if (i % 3 != 0 && i % 5 !=0)
                {
                    Console.WriteLine(i);
                }
               

            }
            Console.ReadLine();
        }
    }
}
