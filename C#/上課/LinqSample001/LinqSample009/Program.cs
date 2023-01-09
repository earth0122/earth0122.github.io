using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            string name = "Bill";
            int age = 40;
            bool isAllBill = list.All((x) => x.Name == name);
            if (isAllBill)
            {
                Console.WriteLine($"全都是{name}");
            }
            else
            {
                Console.WriteLine($"有些人不叫{name}");
            }
            bool isAllOverForty = list.All((x => x.Age >= age));
            if (isAllOverForty)
            {
                Console.WriteLine($"大家都超過{age}歲");
            }
            else
            {
                Console.WriteLine($"有人不到{age}歲");
            }
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData{Name="Bill",Age=47},
                new MyData{Name="John",Age=37},
                new MyData{Name="Tom",Age=48},
                new MyData{Name="David",Age=36},
                new MyData{Name="Bill",Age=35},
            };
        }
    }
    class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
