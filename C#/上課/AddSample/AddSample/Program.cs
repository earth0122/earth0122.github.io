using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 5;
            int i2 = 3;
            double d = 9.8;
            string s1 = "The";
            string s2 = "End";
            Console.WriteLine(i1+i2);  //8 int相加
            Console.WriteLine(i1+d);   //14.8 一個int 一個double 強制同型
            Console.WriteLine(s1+s2);  //The End 兩個string連結
            Console.WriteLine(s1+i1);  //The5 視為兩字串連結
            Console.WriteLine(d+s2);   //9.8End 視為兩字串連結
            Console.ReadLine();        //如果相加有一方是字串 視為字串連結
        }
    }
}
