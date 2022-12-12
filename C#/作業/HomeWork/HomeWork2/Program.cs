using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入一串以逗號分隔的字串:");
            string numstr = Console.ReadLine();
            string[] numArr = numstr.Split(',');
            int[] num = Array.ConvertAll(numArr, int.Parse);
            string s = "";
            string j = "";
            Array.Sort(num);

            foreach (int item in num)
            {
                if (item % 2 != 0)
                {
                    s += item + ",";
                }
                else if (item % 2 == 0)
                {
                    j += item + ",";
                }
            }
            Console.WriteLine($"奇數:{s.TrimEnd(',')}");

            Console.WriteLine($"偶數:{j.TrimEnd(',')}");
            Console.ReadLine();
        }
    }
}
