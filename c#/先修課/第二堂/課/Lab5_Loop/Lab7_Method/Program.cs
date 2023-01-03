using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////輸入字串
            ////string input1 = Console.ReadLine();
            //WriteLog();

            ////輸入字串
            ////string input2 = Console.ReadLine();
            //WriteLog();

            //string str = "My name is Tommy"; 
            //Log(str);
            int number1 = 10;
            int number2 = 20;
            int result = Add(number1, number2);

            WriteLog(result.ToString());


            Console.ReadLine();
        }

        static void WriteLog()
        {
            string input =Console.ReadLine();
            ////抓出時間
            //DateTime now = DateTime.Now;
            ////印出時間:輸入的字
            //Console.WriteLine($"{now}:{input}");
            Log(input);
        }

        static void Log(string source)
        {
            //抓出時間
            DateTime now = DateTime.Now;
            //印出時間:輸入的字
            Console.WriteLine($"{now}:{source}");
        }


        /// <summary>
        /// 兩數相加
        /// </summary>
        /// <param name="num1">第一個數字</param>
        /// <param name="num2">第二個數字</param>
        /// <returns>相加的結果</returns>
        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
