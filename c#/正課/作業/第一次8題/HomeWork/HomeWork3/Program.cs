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
            string numberStr = Console.ReadLine();
            string[] numberArray = numberStr.Split(',');
            Array.Reverse(numberArray);
            // Console.WriteLine(string.Join(",", numberArray));
            string s = "";
            for (int i = 0; i < numberArray.Length; i++)
            {

                s+= numberArray[i] + ',';              
            }
            Console.WriteLine(s.TrimEnd(','));


            Console.ReadLine();

        }
    }
}
