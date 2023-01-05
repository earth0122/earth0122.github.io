using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_JumpStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //    {
            //        break; 
            //    }
            //    Console.WriteLine(i);
            //}
            //int num = 2;
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("數字1");
            //        break;
            //    case 2:
            //        Console.WriteLine("數字2");
            //        break;
            //    default:
            //        Console.WriteLine("不是1或2");
            //        break;
            //}
            //Console.WriteLine("===========================");
            //if (num == 1)
            //{
            //    Console.WriteLine("數字1");
            //}
            //else if (num == 2)
            //{
            //    Console.WriteLine("數字2");
            //}
            //else
            //{
            //    Console.WriteLine("不是1或2");


            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 3)
            //    {
            //       continue;  (continue 跳過)
            //    }
            //    Console.WriteLine(i);
            //}


            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    return;
                }
                Console.WriteLine(i);
            }



            Console.ReadLine();
            }
        }
    }
