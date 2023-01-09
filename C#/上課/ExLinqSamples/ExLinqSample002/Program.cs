using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = CreateList();
            // 找出名稱為 Bill 中的最小 Age
            var min = list.Where((x) => x.Name == "Bill").Min((x) => x.Age);
            Console.WriteLine($"所有 Bill 中最小的年齡是 : {min}");
            // 計算名稱為 Bill 的年齡總和
            var total = list.Where((x) => x.Name == "Bill").Sum((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡總和是 : {total}");
            var average = list.Where((x) => x.Name == "Bill").Average((x) => x.Age);
            Console.WriteLine($"所有 Bill 的年齡平均是 : {average}");

           /* var list = new List<int> { 1, 2, 3, 4 };
            var temp = list.Where(x => x > 3);
            list.Add(5);
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }*/
            
            
            Console.ReadLine();

        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData() { Name = "Bill", Age = 47 },
                new MyData() { Name = "John", Age = 37 },
                new MyData() { Name = "Tom", Age = 48 },
                new MyData() { Name = "David", Age = 36 },
                new MyData() { Name = "Bill", Age = 35 },
            };
        }
        class MyData
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
