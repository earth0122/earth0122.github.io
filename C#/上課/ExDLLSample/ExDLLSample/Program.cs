using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDLLSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle rect = new MyRectangle();
            rect.Width = 10;
            rect.Height = 10;
            Console.WriteLine("面積為:"+rect.GetArea());
            Console.ReadLine();
        }
    }
}
