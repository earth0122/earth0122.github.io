using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串:");
            string numStr =Console.ReadLine();
            string[] numSt = numStr.Split(',');
            int[] num = Array.ConvertAll(numSt, int.Parse);
            Array.Sort(num);
            var result = num.Where(x => x % 2 == 0);
            var result1 = num.Where(x => x % 2 != 0);


           



            Console.WriteLine($"奇數:{string.Join(",",[result1])}");
            Console.WriteLine($"偶數:{string.Join(",",[result])}");
        }
    }
}
