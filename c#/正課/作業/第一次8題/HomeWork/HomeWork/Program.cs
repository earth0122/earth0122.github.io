using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("請輸入一個整數:");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("偶數");
            }
            else
            {
                Console.WriteLine("奇數");
            }
            Console.ReadLine();
           
            /*Console.WriteLine("請輸入一個整數:");
            number=int.Parse(Console.ReadLine());
            bool 
            if (bool=true)
            {

            }*/

        }
    }
}
