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
            Console.Write("請輸入一個整數數字");
            string numStr = Console.ReadLine();
            int num = int.Parse(numStr);
            for (int i = 0; i < num; i++)
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write(num - i);
                }            
               
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
