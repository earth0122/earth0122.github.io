using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstInheritSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            bool result = o1.Equals(o2);
            Console.WriteLine($"o1 Equals (o2) is +{result}");

            Console.ReadLine();
        }
    }
    class Class1
    {
        
    }
}
