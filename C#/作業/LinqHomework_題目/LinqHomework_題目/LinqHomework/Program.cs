using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //影片資料集合
            List<Video> videoList = new List<Video>() {
                new Video() { Name = "天竺鼠車車", Country = "日本", Duration = 2.6, Type = "動漫" },
                new Video() { Name = "鬼滅之刃", Country = "日本", Duration = 25, Type = "動漫" },
                new Video() { Name = "鬼滅之刃-無限列車", Country = "日本", Duration = 100, Type = "電影" },
                new Video() { Name = "甜蜜家園SweetHome", Country = "韓國", Duration = 50, Type = "影集" },
                new Video() { Name = "The 100 地球百子", Country = "歐美", Duration = 48, Type = "影集" },
                new Video() { Name = "冰與火之歌Game of thrones", Country = "歐美", Duration = 60, Type = "影集" },
                new Video() { Name = "半澤直樹", Country = "日本", Duration = 40, Type = "影集" },
                new Video() { Name = "古魯家族：新石代", Country = "歐美", Duration = 90, Type = "電影" },
                new Video() { Name = "角落小夥伴電影版：魔法繪本裡的新朋友", Country = "日本", Duration = 77, Type = "電影" },
                new Video() { Name = "TENET天能", Country = "歐美", Duration = 80, Type = "電影" },
                new Video() { Name = "倚天屠龍記2019", Country = "中國", Duration = 58, Type = "影集" },
                new Video() { Name = "下一站是幸福", Country = "中國", Duration = 45, Type = "影集" },
            };

            //人物資料集合
            List<Person> personList = new List<Person>()
            {
                new Person() 
                { 
                    Name = "Bill", 
                    CountryPrefer = new List<string>() 
                    { 
                        "中國", "日本" 
                    }, 
                    TypePrefer = new List<string>() 
                    { 
                        "影集" 
                    } 
                },
                new Person() { Name = "Jimmy", CountryPrefer = new List<string>() { "日本" }, TypePrefer = new List<string>() { "動漫", "電影" } },
                new Person() { Name = "Andy", CountryPrefer = new List<string>() { "歐美", "日本" }, TypePrefer = new List<string>() { "影集", "電影" } },
            };

            // 1. 找出所有日本的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有日本的影片名稱");

            var result1 =
               from x in videoList
               where x.Country == "日本"
               select x;
            var a = videoList.Where(x => x.Country == "日本").Select(x => x.Name);
            Console.WriteLine(String.Join(Environment.NewLine, result1));            
            Console.WriteLine(String.Join(Environment.NewLine, a));
            // 2. 找出所有歐美的影片且類型為"影集"的影片名稱
            Console.WriteLine($"{Environment.NewLine}Q: 找出所有歐美的影片且類型為'影集'的影片名稱");

            var result2 = 
               from x in videoList
                where x.Country == "歐美" && x.Type == "影集"
               select x ;
            var b = videoList.Where(x => x.Country == "歐美" && x.Type == "影集").Select(x => x.Name);
            Console.WriteLine(String.Join(Environment.NewLine, result2));
            Console.WriteLine(String.Join(Environment.NewLine, b));
            // 3. 是否有影片片長超過120分鐘的影片
            Console.WriteLine($"{Environment.NewLine}Q: 是否有影片片長超過120分鐘的影片");

            //var result3 = 
            //    from x in videoList
            //    where  x.Duration > 120
            //    select x;
            //if (result3 == 0)
            //{
            //    Console.WriteLine("沒有影片超過120分鐘");
            //}
            //var c = videoList.Where(x => x.Duration > 120).Select(x => x.Name);
            //Console.WriteLine(String.Join(Environment.NewLine, result3));
            //Console.WriteLine(String.Join(Environment.NewLine, c));
            // 4. 請列出所有人的名稱，並且用大寫英文表示，ex: Bill -> BILL
            Console.WriteLine($"{Environment.NewLine}Q: 請列出所有人的名稱，並且用大寫英文表示");

            var result4 =
                from x in personList
                 select x.Name.ToUpper();
            var d = personList.Select(x => x.Name.ToUpper());
            Console.WriteLine(String.Join(Environment.NewLine, result4));
            Console.WriteLine(String.Join(Environment.NewLine, d));
            // 5. 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名，ex: No1: 天竺鼠車車
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片用片長排序(最長的在前)，並顯示排序過的排名以及片名");

            //var result5 =
            //    from x in videoList
            //    orderby x.Duration descending
            //    select x, index  $"No{index + 1}:{x.Name}");
            //var e = videoList.OrderByDescending(x => x.Duration);
            //var f = e.Select((x, index1) => $"No{index1 + 1}:{x.Name}");
            //Console.WriteLine(String.Join(Environment.NewLine, result5));
            //Console.WriteLine(String.Join(Environment.NewLine, f));
            // 6. 將所有影片進行以"類型"分類，並顯示以下樣式(注意縮排)
            /* 
            動漫:
                天竺鼠車車
                鬼滅之刃
            */
            Console.WriteLine($"{Environment.NewLine}Q: 將所有影片進行以'類型'分類");
            var result6 =
               from x in videoList
               group x by x.Type into y
               select y;


            var g = videoList
                .GroupBy(x => x.Type)
                .Select(y=>$"{y.Key}:{Environment.NewLine}{string.Join(Environment.NewLine,y.Select(z=>$"\t{z.Name}"))}");

            Console.WriteLine(String.Join(Environment.NewLine, result6));
            Console.WriteLine(String.Join(Environment.NewLine, g));

            // 7. 找到第一個喜歡歐美影片的人
            Console.WriteLine($"{Environment.NewLine}Q: 找到第一個喜歡歐美影片的人");


            var h = personList.FirstOrDefault(x => x.CountryPrefer.Contains ("歐美"));
            Console.WriteLine($"第一個喜歡歐美影片的人是{h.Name}");

            // 8. 找到每個人喜歡的影片(根據國家以及類型)，ex: Bill: 天竺鼠車車, 倚天屠龍記2019
            Console.WriteLine($"{Environment.NewLine}Q: 找到每個人喜歡的影片");

            // 9. 列出所有類型的影片總時長，ex: 動漫: 100min    sum
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有類型的影片總時長");

            // 10. 列出所有國家出產的影片數量，ex: 日本: 3部   count
            Console.WriteLine($"{Environment.NewLine}Q: 列出所有國家出產的影片數量");

            //var k = videoList.;
            //Console.ReadLine();
        }
    }
}
