using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Method_練習
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //輸入字串
            //string input1 = Console.ReadLine();
            WriteLog();

            //輸入字串
            //string input2 = Console.ReadLine();
            WriteLog("外面進來的String");
            WriteLog("外面進來的_1", "外面進來的_2");
            WriteLog("外面進來的_1", 1);
            Console.ReadLine();
        }
        static void WriteLog()
        {
            Console.WriteLine("使用空的"); ;
        }

        static void WriteLog(string source)
        {
            Console.WriteLine($"out method key in : {source}");
            ////2:28:00
            //string input = Console.ReadLine();

            ////抓出時間
            //DateTime now = DateTime.Now;
            ////印出時間:輸入的字串
            //Console.WriteLine($"method time :{now}\r\nmethod key in:{input}");
        }
        static void WriteLog(string source_1, string source_2)
        {
            Console.WriteLine($"out method key in first : {source_1}");
            Console.WriteLine($"out method key in sec : {source_2}");
        }
        static void WriteLog(string source, int source_num)
        {
            Console.WriteLine($"out method key in : {source} num :{source_num}");
        }
    }
}
