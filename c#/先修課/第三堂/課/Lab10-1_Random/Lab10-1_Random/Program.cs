using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {//產出一個可以使用亂數的物件
            Random random = new Random();
            //隨機整數的數字
            int num1 = random.Next();
            Console.WriteLine(num1);
            //隨機產生小於10的整數數字
            int num2 = random.Next(10);
            Console.WriteLine(num2);
            //隨機產生大於等於於10小於100的整數數字
            int num3 = random.Next(10, 100);
            Console.WriteLine(num3);
            //隨機整數的小數
            double num4 = random.NextDouble();
            Console.WriteLine(num4);


            Console.WriteLine($"第一個亂數:{num1}");
            Console.WriteLine($"第二個亂數:{num2}");
            Console.WriteLine($"第三個亂數:{num3}");
            Console.WriteLine($"第四個亂數:{num4}");

            Console.ReadLine();
        }
    }
}
