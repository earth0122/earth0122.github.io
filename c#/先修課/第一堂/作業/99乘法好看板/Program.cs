using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99乘法好看板
{
    internal class Program
    {
        static void Main(string[] args)
        {   //                      x+=1   x=x+1
            for (int x = 1; x < 10; x++)
            {
                
                for (int y = 1; y < 10; y++)
                {
                    //藉由跳脫字元\t，來使排版更好看    
                    Console.Write($"{x}*{y}={x*y}\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }

    }
}
            