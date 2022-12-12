using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i =1;
            while (i<11)
            {
               result=result+i;
                i++;
            }
            Console.WriteLine($"加總結果:{result}");
            Console.ReadLine();
        }
    }
}
