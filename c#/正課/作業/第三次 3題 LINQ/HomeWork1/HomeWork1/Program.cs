using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一串以逗號分隔的字串");
            string numStr = Console.ReadLine();
            string[] numSt = numStr.Split(',');
            int[] numINT = Array.ConvertAll(numSt, int.Parse);
           
            var result = numINT.Reverse();
            /* var a =from num in numINT
                    join num in numINT
                    select num;*/
            Console.WriteLine($"結果{string.Join(",", result)}");
            Console.ReadLine();
        }
    }
}
