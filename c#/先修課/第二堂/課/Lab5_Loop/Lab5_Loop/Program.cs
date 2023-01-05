using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //57分
            int index = 0;
            while (index<array.Length)
            {
                Console.WriteLine(array[index]);
                index++;//不加的話 會一直近來這個迴圈(無窮迴圈)
            }




            //字串的Array? Andy Dann Jimmy 逐個印出來

            string[] arrayStr = new string[] { "Andy", "Dann", "Jimmy", "Kevin" };
            //foreach
            foreach (string item in arrayStr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //for
            for (int i = 0; i < arrayStr.Length; i++)
            {
                Console.WriteLine(arrayStr[i]);
            }
            //while
            
            //索引(拿出陣列裡面的職)
            int index2 = 0;
            while (index2<arrayStr.Length)
            {
                Console.WriteLine(array[index2]);
                index2++;
            }


            Console.ReadLine();
        }
    }
}
