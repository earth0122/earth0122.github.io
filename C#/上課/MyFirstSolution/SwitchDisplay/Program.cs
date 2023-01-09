using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("請輸入一個數字:");
            string input = Console.ReadLine();
            value = int.Parse(input);
            Display(value);
            Console.ReadLine();
        }

        private static void Display(int value)
        {
            switch (value)
            {
                case 1:
                    Console.WriteLine("數字是1");
                    break;
                case 2:
                    Console.WriteLine("數字是2");
                    break;
                default:
                    Console.WriteLine("數字不再條件內");
                    break;
            }
        }
    }
}
