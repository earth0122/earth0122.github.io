using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            var list = CreateList();
            // 這裡的 person 是單個物件, 也就是 MyData person
            var person = list.ElementAtOrDefault(index);
            if (person == null)
            {
                Console.WriteLine("查無此人");
            }
            else
            {
                Console.WriteLine($"找到索引為 : {index} 的人是 {person.Name}-{ person.Age}");
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
