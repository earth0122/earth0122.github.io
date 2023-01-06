using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("輸入一串以逗號分隔的整數數字字串");
            string numberStr = Console.ReadLine();
            string[] numberArray = numberStr.Split(',');
            int[] number = Array.ConvertAll(numberArray, int.Parse);
            Array.Sort(number);
            string a = "";
            string b = "";
            foreach (int oddNum in number)
            {
                if (oddNum % 2!=0)
                {

                    a+=oddNum+",";
                }
            }

             foreach (int even in number)
             {
                 if (even % 2 == 0)
                 {
                    b += even + ",";
                 }
             }


            //a = a.Substring(0,a.Length - 1)
            Console.WriteLine($"奇數:{a.Substring(0,a.Length-1)}");
            //b=b.TrimEnd(',')
            Console.WriteLine($"偶數:{b.TrimEnd(',')}");
            Console.ReadLine();






           /* 字符串：string s = "1,2,3,4,5,"
目标：删除最后一个 ","

方法：
1、用的最多的是Substring，这个也是我一直用的
s = s.Substring(0, s.Length - 1)
2、用TrimEnd,这个东西传递的是一个字符数组

s = s.TrimEnd(',')
//如果要删除"5,"，则需要这么写
char[] MyChar = { '5', ',' };
            s = s.TrimEnd(MyChar);

            //s = "1,2,3,"
            3、用Remove
string a = "123";
            a = a.Remove(a.Length - 1, 1); //移除掉","*/








            /*bool Right = true;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    Right = true;                  
                }
                else
                {
                   Right=false;
                }
            }
            if (Right)
            {
                Console.WriteLine($"奇數:{number}");
            }
            else
            {
                Console.WriteLine($"偶數:{number}");
            }
            Console.ReadLine();*/



        }
    }
}
