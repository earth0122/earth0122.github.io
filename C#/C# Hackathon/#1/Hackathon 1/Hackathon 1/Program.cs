using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個至少大於90的整數:");        

           /* int intNum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out intNum))
                {
                    if (intNum <= 90)
                    {
                        Console.WriteLine("請輸入至少大於90的一個整數");
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Unable to report the measurement.");
                    continue;
                }
            }*/
            string numStr=Console.ReadLine();
            int max = int.Parse(numStr);
            for (int i = 1; i <= max; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("school");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

        }
    }
}
