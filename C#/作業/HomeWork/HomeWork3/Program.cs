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
            Console.WriteLine("輸入一串以逗號分隔的字串:");
            string numStr = Console.ReadLine();
            string[] numArray = numStr.Split(',');
            Array.Reverse(numArray);
            string s = "";
            for (int i = 0; i < numArray.Length; i++)
            {
                s += numArray[i] + ',';

            }
            Console.WriteLine($"{s.TrimEnd(',')}");
            Console.ReadLine();
        }
    }
}
