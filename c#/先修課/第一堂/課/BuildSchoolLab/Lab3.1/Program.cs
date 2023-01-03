using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string 下班要帶的東西 = "一斤包子";
            bool 遇到賣西瓜的 = true;
            if (遇到賣西瓜的)
            {
                Console.WriteLine("遇到賣西瓜的了!!!");
                下班要帶的東西 = "一個包子";
            }
            Console.WriteLine(下班要帶的東西);
            Console.ReadLine(); 
                
        }
    }
}
