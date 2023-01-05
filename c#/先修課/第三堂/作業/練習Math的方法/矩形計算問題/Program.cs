using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 矩形計算問題
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRectangle r = new MyRectangle
            {
                Height = 10,
                Width = 10,
            };
            //利用方法ShowRectangle(r) 來把下面需要運算的東西全部算完 藉此來讓main方法裡 更簡潔

            ShowRectangle(r);
            Console.ReadLine();
        }
        //設定一個方法ShowRectangle 從下面的類別MyRectangle裡 把需要用到的東西丟進來 讓以後需要運算這個東西 呼叫方法就可以算
        static void ShowRectangle(MyRectangle rectangle)
        {
            Console.WriteLine($"長方祥的面積:{rectangle.GetArea()},周長:{rectangle.GetPerimeter()}");
        }
    }

    //限定在矩形類別MyRectangle 然後在裡面設定物件Height和Width 並且把周長和面積的運算 放在MyRectangle這裡面
    public class MyRectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double GetPerimeter()
        {
            return 2 * (Height + Width);
        }
        public double GetArea()
        {
            return Height * Width;
        }
    }

}
