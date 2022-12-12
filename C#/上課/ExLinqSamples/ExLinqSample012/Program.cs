using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            var order1 =
                from o in list
                orderby o.Name,o.Age
                select o;
            Display(order1);
            var order2 = 
                from o in list
                orderby o.Name descending,o.Age descending
                select o;
            Display(order2);
            Console.ReadLine();
        }
        static void Display(IOrderedEnumerable<MyData> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine($"{item.Name} : {item.Age}");
            }
            Console.WriteLine("-------------");
        }

        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData {Name="Bill",Age=47},
                new MyData {Name="John",Age=37},
                new MyData {Name="Tom",Age=48},
                new MyData {Name="David",Age=36},
                new MyData {Name="Bill",Age=35},
            };
        }
    }
    class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
