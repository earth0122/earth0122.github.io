using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 這裡的 person1 是單個物件, 也就是 MyData person1
            var person1 = list.SingleOrDefault((x) => x.Name == "Tom");
            Console.WriteLine($"找到唯一的 : {person1.Name} - {person1.Age}");
            // 因為找不到唯一 (裡面有兩個 Bill) 就會跳出例外
            var person2 = list.Single((x) => x.Name == "Bill");
            Console.WriteLine($"找到唯一的 : {person2.Name} - {person2.Age}");
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
        {
            new MyData{ Name="Bill",Age=47 },
            new MyData{ Name="John",Age=37 },
            new MyData{ Name="Tom",Age=48 },
            new MyData{ Name="David",Age=36 },
            new MyData{ Name="Bill",Age=35 },
        };
        }
    }
   
    class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
