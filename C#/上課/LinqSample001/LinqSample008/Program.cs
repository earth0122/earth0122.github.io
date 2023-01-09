using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            string name = "David";
            bool result = list.Any((x) => x.Name == name);
            if (result)
            {
                Console.WriteLine($"找到了:{name}");
            }
            else
            {
                Console.WriteLine($"找不到:{name}");
            }
            Console.ReadLine();
        }
        
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData{Name="Bill",Age=47 },
                new MyData{Name="John",Age=37 },
                new MyData{Name="Tom",Age=48 },
                new MyData{Name="David",Age=36 },
                new MyData{Name="Bill",Age=35 },
            };
        }
    }
    class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
