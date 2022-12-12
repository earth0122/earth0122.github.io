using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個整數數字:");
            int num =int.Parse(Console.ReadLine());
            if (num %2 !=0)
            {
                Console.WriteLine("奇數");
            }
            else
            {
                Console.WriteLine("偶數");
            }
            Console.ReadLine();
            

            
        }
    }
}
