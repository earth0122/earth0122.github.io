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
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string numStr = Console.ReadLine();
            string[] numSt = numStr.Split(',');
            int[] numINT = Array.ConvertAll(numSt, int.Parse);
            Array.Sort(numINT);
            //var a =from num in numINT    
            //       where num %2 == 0
            //       select num;
            var result1 = numINT.Where(num => num % 2 == 0);
            //var b = from num in numINT
            //        where num % 2 != 0
            //        select num;
            var result2 = numINT.Where(num => num % 2 != 0);

            Console.Write($"奇數:{String.Join(",", result2)}");
            Console.Write($"奇數:{String.Join(",", result1)}");
            //Console.Write($"奇數:{String.Join(",", b)}");
            //Console.Write($"偶數數:{String.Join(",", a)}");
            Console.ReadLine();
        }
    }
}
