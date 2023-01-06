using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_ArrayAndLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, };
            string[] strs = { "Do", "Re", "Mi","Fa","So","La"};
            //Console.WriteLine(numbers[4]);
            //Console.WriteLine(strs[0]);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(strs[i]);
            }
            
            Console.ReadLine();
        }
    }
}
