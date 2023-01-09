using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            string numStr=Console.ReadLine();
            int num = int.Parse(numStr);
            for (int i = 1; i <= num; i++)
            {
                int nums = num - i + 1;
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
