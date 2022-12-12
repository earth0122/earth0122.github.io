using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1.Execute();
            Console.ReadLine();
        }
    }
    public static class Class1
    {
        private static int x = 100;
        public static void Execute()
        {
            Console.WriteLine($"This is {x}");
        }
    }
}
