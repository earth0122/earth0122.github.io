using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Declare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //型別 變數名稱 = 值
            //姓名
            string name = "Tommy";
            //年齡
            int age = 28;
            //陣列
            int[] array = new int[] { 2, 4, 6, 8, 10 }; 
            
            Console.WriteLine(name);
            
            Console.WriteLine(age);
            //Array沒有辦法直接印出值，只會印出型別，需要透過索引取得陣列的值
            //索引[]要從0開始
            Console.WriteLine(array[0]);
            
            Console.ReadLine();
         }
    }
}
