using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSample003
{
    internal class Program
    {
        static void Main(string[] args)
        {   //開始用var    
            var list = CreateList();
            // 這裡的 person1 是單個物件, 也就是 MyData person1           
            var person1 = list.FirstOrDefault((x) => x.Age < 37);
            Console.WriteLine($"小於37的人第一個被找到的是:{person1.Name}");
            // 因為找不到, 就會跳出例外 在person2.Name那邊
            var person2 = list.First((x) => x.Age < 30);
            Console.WriteLine($"小於30的人第一個被找到的是:{person2.Name}");
            Console.ReadLine();
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Name = "Bill", Age = 47 },
                new MyData { Name = "John", Age = 37 },
                new MyData { Name = "Tom", Age = 48 },
                new MyData { Name = "David", Age = 36 },
                new MyData { Name = "Bill",Age = 35 },
            };
        }
    }
    class MyData
    {
        public string Name
        { get; set; }
        public int Age
        { get; set; }
    }
}
