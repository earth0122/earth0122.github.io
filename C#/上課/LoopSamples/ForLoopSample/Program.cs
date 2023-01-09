using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        //可以用梯形公式去算(上+下)*高/2
        {
            int result =0;
            for (int i = 1; i < 11; i++)
            {
                result = result + i;
                //也可以寫成
                //result +=i
            }
            Console.WriteLine($"加總結果{result}");
            Console.ReadLine();
        }
    }
}
