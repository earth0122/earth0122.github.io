using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,1));
            Console.WriteLine(Add(1,2,3));
            Console.WriteLine(Add(1.5,3.2));
            Console.WriteLine(Add(9.8,7));
            Console.WriteLine(Add("A","B"));
            Console.WriteLine(Add("XYZ",100));
            Console.ReadLine();
            
        }
        static int Add(int x,int y)
            { return x + y; }
        static int Add(int x,int y,int z)
            { return x + y + z; }
        static double Add(double x, double y)
        { return (x + y); }
        static string Add(string x, string y)
        { return x + y; }
        static string Add(string x, int y)
        { return x + "整數" + y.ToString(); }
    }
}
