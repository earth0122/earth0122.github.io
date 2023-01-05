using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9, 2, 4, 6 };
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Array.Sort(array);
            Console.WriteLine("排序後");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            //int[] array3;
            //array3=new int[]{1,3,5};
            //array3= {1,3,5,7,9,}; //error
        }
    }
}
