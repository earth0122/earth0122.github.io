using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_2_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //印出2的0~10次方
            //int num = 2;
            //for (int i = 0; i < 11; i++)
            //{
            //    double result = Math.Pow(num, i);
            //    Console.WriteLine(result);
            //}

            //四捨五入
            Double num2 = 12.777777;
            double result = Math.Round(num2,2); //後面,2代表到小數點第幾位
            Console.WriteLine(result);
            
            Console.ReadLine();
        }
    }
}
