using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //要算1-200的質數 所以先做一個2開始加到200的迴圈 每次+1 由於1不是質數 所以從2開始
            for (int i = 2; i < 201; i++)
            {
                //質數的定義是指只能被自己和1整除 所以在設定一個迴圈 讓i除小等於自己所有的正整數 來判斷當i不等於j的時候餘數會不會是0 是0的話就代表有其他因數
                //ex  要算11是不是質數 就要把11/2 11/3一直到11/10為止 都有餘數的話他就是質數
                for (int j = 2; j <= i; j++)
                {
                    //條件設定如果算出來餘數==0 而且i不等於j 那就代表不是質數                    
                    if (i % j == 0 && i != j)
                    {
                        break;                        
                    }
                    else if (i == j)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
