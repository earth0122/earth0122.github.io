using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字z");


            //輸入數字，放到變數z
            int z = int.Parse(Console.ReadLine());
            //輸入數字，放到變數b
            Console.WriteLine("請輸入數字b");
            int b = int.Parse(Console.ReadLine());
            //判斷z跟b的大小顯示對應的文字
            if (z > b)
            {
                Console.WriteLine("z大於b");
            }
            else if (z == b)
            {
                Console.WriteLine("z等於b");
            }
            else
            {
                Console.WriteLine("z小於b");
            }

            //格式化字串
            Console.WriteLine("z等於b{0}", z == b);
            //字串插補
            Console.WriteLine($"z等於b{z == b}"); 

            Console.ReadLine();
        }
    }
}
