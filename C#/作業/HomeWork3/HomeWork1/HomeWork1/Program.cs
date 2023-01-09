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
            Console.WriteLine("輸入一串以逗號分隔的字串:");
            string numStr = Console.ReadLine();
            string[] numSt = numStr.Split(',');
            var result = numSt.Reverse();
            Console.WriteLine(string.Join(",",result));


            Console.ReadLine();
        }
    }
}
