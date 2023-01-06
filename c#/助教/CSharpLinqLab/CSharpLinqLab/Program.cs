using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLinqLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ItemObj>
            {
                new ItemObj { Name = "啤酒", Type = "喝的" },
                new ItemObj { Name = "汽水", Type = "喝的" },
                new ItemObj { Name = "火鍋", Type = "吃的" },
                new ItemObj { Name = "燒烤", Type = "吃的" },
                new ItemObj { Name = "冰淇淋", Type = "吃的" },
            };

            //我要找第一個 "吃的" 的東西
            //first 、 firstOrDefault 、 find
            var r1 = list.First(x => x.Type == "吃的");
            Console.WriteLine(r1.Name);

            //找所有 "吃的" 的東西
            //Where
            var r2 = list.Where(x => x.Type == "吃的");
            Console.WriteLine(string.Join(", ", r2.Select(x => x.Name)));

            //找 "冰淇淋" 在第幾個位置
            var ice = list.Find(x => x.Name == "冰淇淋");
            var r3_1 = list.IndexOf(ice);
            Console.WriteLine(r3_1);

            var r3_2 = list.FindIndex(x => x.Name == "冰淇淋");
            Console.WriteLine(r3_2);

            //用 list 產生新的集合
            //['啤酒', '汽水', '火鍋', ....]
            var r4 = list.Select(x => x.Name);
            Console.WriteLine(string.Join(", ", r4));

            //用 list 產生新的集合
            //[
            //  { id: 5, name: '啤酒' },
            //  { id: 4, name: '汽水' },
            //  { id: 3, name: '火鍋' },
            //  { id: 2, name: '燒烤' },
            //  { id: 1, name: '冰淇淋' }
            //]
            var r5 = list.Select((x, idx) => new
            {
                Id = list.Count - idx,
                Name = x.Name
            });

            //排序
            var num_1 = new int[] { 9, 6, 4, 2, 1 };
            var r6 = num_1.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", r6));

            var num_2 = new int[] { 10000, 10, 100, 1, 101 };
            var r7 = num_2.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", r7));

            //拿 r5 用Id排序
            var r8 = r5.OrderBy(x => x.Id);

            //12生肖排序
            //['豬', '龍', '鼠', '狗', '羊', '雞', '馬']
            var animal = new List<string> { "豬", "龍", "鼠", "狗", "羊", "雞", "馬" };
            var zodiac = new List<string> { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };

            //v1
            var sortedAnimal_1 = animal.OrderBy(x => zodiac.IndexOf(x));

            //v2
            var sortedAnimal_2 = animal.OrderBy(x => x, new ZodiacCompare());

            Console.ReadLine();
        }
    }

    class ZodiacCompare : IComparer<string>
    {
        static List<string> zodiac = new List<string> { "鼠", "牛", "虎", "兔", "龍", "蛇", "馬", "羊", "猴", "雞", "狗", "豬" };
        public int Compare(string x, string y)
        {
            //if (zodiac.IndexOf(x) > zodiac.IndexOf(y)) return 1;
            //else if (zodiac.IndexOf(x) < zodiac.IndexOf(y)) return -1;
            //else return 0;

            return zodiac.IndexOf(x) - zodiac.IndexOf(y);
        }
    }

    class ItemObj
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}